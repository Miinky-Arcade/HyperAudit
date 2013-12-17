using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

using StringSet = System.Collections.Generic.HashSet<string>;
using StringList = System.Collections.Generic.List<string>;

namespace HyperAudit {

    class Auditor {

        private AuditData _database;

        /// <summary>
        /// Stores the total number of games found during a full audit
        /// </summary>
        private int _totalGameCount;
        public int TotalGameCount {
            get {
                return _totalGameCount;
            }
        }

        /// <summary>
        /// Lists all systems we have found a database file for
        /// </summary>
        private StringList _allSystems;
        public StringList AllSystems {
            get {
                return _allSystems;
            }
        }

        // Paths to database files
        private const string kPathToDatabasesDir = "Databases";
        private const string kPathToDatabaseFile = "Databases\\{0}\\{0}.xml";

        // Paths to artwork directories
        private const string kPathToArtworkDir = "{0}\\Images\\Artwork{1:d}";
        private const string kPathToWheelArtDir = "{0}\\Images\\Wheel";
        private const string kPathToVideosDir = "{0}\\Video";
        private const string kPathToThemesDir = "{0}\\Themes";
        private const string kPathToPointerImg = "{0}\\Images\\Other\\Pointer.png";
        private const string kPathToLettersImg = "{0}\\Images\\Letters\\a.png";

        // Paths for main menu data
        private const string kMainMenuMediaFolder = "Main Menu";
        private const string kPathToMainMenuWheel = "Main Menu\\Images\\Wheel\\{0}.png";
        private const string kPathToMainMenuTheme = "Main Menu\\Themes\\{0}.zip";
        private const string kPathToMainMenuVideo = "Main Menu\\Video\\{0}.{1}";

        // File extensions for known types
        private const string kFileExtImage = ".png";
        private const string kFileExtTheme = ".zip";

        // Used internally for constructing paths based on those read from the config file
        private enum PathType {
            Base,
            Media,
            ROMs
        };


        public Auditor(AuditData database) {
            _allSystems = new StringList();
            _database = database;
        }


        /// <summary>
        /// Refreshes all systems and performs an audit on them all
        /// </summary>
        public void refreshAllSystems() {
            populateSystemsList();
            auditSystems();
        }


        /// <summary>
        /// Refreshes the detailed info on a system, populating the details table
        /// </summary>
        /// <param name="systemName">Name of the system to fetch details for</param>
        public void refreshSystemDetails(string systemName) {

        }


        /// <summary>
        /// Gets the full path to a directory by reading the config file for
        /// base paths and appending the relative path.
        /// </summary>
        private string getFullPath(string relative, PathType type) {
            switch (type) {
                case PathType.Base:
                    return ConfigurationSettings.AppSettings["HS_DIR"] + "\\" + relative;
                case PathType.Media:
                    return ConfigurationSettings.AppSettings["MEDIA_DIR"] + "\\" + relative;
                case PathType.ROMs:
                    return ConfigurationSettings.AppSettings["ROMS_DIR"] + "\\" + relative;
            }
            return "";
        }


        /// <summary>
        /// Helper function to extract configured video filetype from config file
        /// </summary>
        /// <returns></returns>
        private string getVideosExtension() {
            return ConfigurationSettings.AppSettings["VIDEO_EXT"];
        }


        /// <summary>
        /// Returns the md5 hash of the file data for the given file
        /// </summary>
        /// <param name="filename">Path to the file to check</param>
        /// <returns>String representing the MD5 hash of the file</returns>
        private string md5file(string filename) {
            using (var md5 = MD5.Create()) {
                using (var stream = File.OpenRead(filename)) {
                    byte[] result = md5.ComputeHash(stream);
                    return System.Text.Encoding.UTF8.GetString(result);
                }
            }
        }


        /// <summary>
        /// Generates a list of enabled systems based on existance of database files
        /// </summary>
        private void populateSystemsList() {
            _allSystems.Clear();
            string dbdir = getFullPath(kPathToDatabasesDir, PathType.Base);
            if (!Directory.Exists(dbdir))
                throw new HAException("Could not read databases dir: " + dbdir);

            string[] subDirs = Directory.GetDirectories(dbdir);
            foreach (string dir in subDirs) {
                string systemName = dir.Substring(dir.LastIndexOf('\\') + 1);
                if (systemName == kMainMenuMediaFolder)
                    continue;

                string dbfile = getFullPath(kPathToDatabaseFile, PathType.Base);
                if (File.Exists(String.Format(dbfile, systemName)))
                    _allSystems.Add(systemName);
            }
        }


        /// <summary>
        /// Runs an audit on all detected systems and updates the allSystems
        /// table in the database.
        /// </summary>
        private void auditSystems() {
            _database.allSystemsTable.Clear();
            _totalGameCount = 0;

            string romsPath = getFullPath("", PathType.ROMs) + "\\{0}";
            string artDir = getFullPath(kPathToArtworkDir, PathType.Media);
            string videosDir = getFullPath(kPathToVideosDir, PathType.Media);
            string themesDir = getFullPath(kPathToThemesDir, PathType.Media);
            string wheelArtDir = getFullPath(kPathToWheelArtDir, PathType.Media);

            string pointerPath = getFullPath(kPathToPointerImg, PathType.Media);
            string letterPath = getFullPath(kPathToLettersImg, PathType.Media);
            string defaultPointerHash = md5file(String.Format(pointerPath, kMainMenuMediaFolder));
            string defaultLetterHash = md5file(String.Format(letterPath, kMainMenuMediaFolder));

            string menuWheelArtPath = getFullPath(kPathToMainMenuWheel, PathType.Media);
            string menuThemePath = getFullPath(kPathToMainMenuTheme, PathType.Media);
            string menuVideoPath = getFullPath(kPathToMainMenuVideo, PathType.Media);

            foreach (string systemName in _allSystems) {
                StringSet romsList = getFileList(String.Format(romsPath, systemName));
                StringSet art1List = getFileList(String.Format(artDir, systemName, 1), kFileExtImage);
                StringSet art2List = getFileList(String.Format(artDir, systemName, 2), kFileExtImage);
                StringSet art3List = getFileList(String.Format(artDir, systemName, 3), kFileExtImage);
                StringSet art4List = getFileList(String.Format(artDir, systemName, 4), kFileExtImage);
                StringSet wheelArtList = getFileList(String.Format(wheelArtDir, systemName), kFileExtImage);
                StringSet videosList = getFileList(String.Format(videosDir, systemName), getVideosExtension());
                StringSet themesList = getFileList(String.Format(themesDir, systemName), kFileExtTheme);

                themesList.Remove("default");

                int gameCount = 0, romCount = 0, art1Count = 0, art2Count = 0, art3Count = 0,
                    art4Count = 0, wheelArtCount = 0, videoCount = 0, themeCount = 0;

                StringList gamesList = getListOfGamesFromDatabase(systemName);
                foreach (string gameName in gamesList) {
                    gameCount++;
                    romCount += romsList.Remove(gameName) ? 1 : 0;
                    art1Count += art1List.Remove(gameName) ? 1 : 0;
                    art2Count += art2List.Remove(gameName) ? 1 : 0;
                    art3Count += art3List.Remove(gameName) ? 1 : 0;
                    art4Count += art4List.Remove(gameName) ? 1 : 0;
                    wheelArtCount += wheelArtList.Remove(gameName) ? 1 : 0;
                    videoCount += videosList.Remove(gameName) ? 1 : 0;
                    themeCount += themesList.Remove(gameName) ? 1 : 0;
                }

                // Check the one-off items for each system
                bool customPointer = !defaultPointerHash.Equals(md5file(String.Format(pointerPath, systemName)));
                bool customLetters = !defaultLetterHash.Equals(md5file(String.Format(letterPath, systemName)));
                bool mainMenuWheelArt = File.Exists(String.Format(menuWheelArtPath, systemName));
                bool mainMenuTheme = File.Exists(String.Format(menuThemePath, systemName));
                bool mainMenuVideo = File.Exists(String.Format(menuVideoPath, systemName, getVideosExtension()));

                // Add the row to the database
                _database.allSystemsTable.Rows.Add(systemName,
                    romCount + "/" + gameCount + (romsList.Count > 0 ? ", " + romsList.Count + " unmatched" : ""),
                    art1Count + "/" + gameCount + (art1List.Count > 0 ? ", " + art1List.Count + " unmatched" : ""),
                    art2Count + "/" + gameCount + (art2List.Count > 0 ? ", " + art2List.Count + " unmatched" : ""),
                    art3Count + "/" + gameCount + (art3List.Count > 0 ? ", " + art3List.Count + " unmatched" : ""),
                    art4Count + "/" + gameCount + (art4List.Count > 0 ? ", " + art4List.Count + " unmatched" : ""),
                    wheelArtCount + "/" + gameCount + (wheelArtList.Count > 0 ? ", " + wheelArtList.Count + " unmatched" : ""),
                    videoCount + "/" + gameCount + (videosList.Count > 0 ? ", " + videosList.Count + " unmatched" : ""),
                    themeCount + "/" + gameCount + (themesList.Count > 0 ? ", " + themesList.Count + " unmatched" : ""),
                    customPointer,
                    customLetters,
                    mainMenuWheelArt,
                    mainMenuTheme,
                    mainMenuVideo);

                _totalGameCount += romCount;
            }
        }


        /// <summary>
        /// Helper function for parsing a list of games out of an XML file.
        /// </summary>
        /// <param name="systemName">System name to scan database for</param>
        /// <returns>List of strings that are method signatures</returns>
        private StringList getListOfGamesFromDatabase(string systemName) {
            string xmlPath = getFullPath(kPathToDatabaseFile, PathType.Base);
            xmlPath = String.Format(xmlPath, systemName);
            if (!File.Exists(xmlPath))
                throw new HAException("Could not read database file for " + systemName + " at " + xmlPath);

            StringList result = new StringList();
            XmlTextReader reader = new XmlTextReader(xmlPath);
            while (reader.Read()) {
                switch (reader.NodeType) {
                    case XmlNodeType.Element:
                        if (reader.Name.Equals("game", StringComparison.CurrentCultureIgnoreCase)) {
                            while (reader.MoveToNextAttribute()) {
                                if (reader.Name.Equals("name", StringComparison.CurrentCultureIgnoreCase)) {
                                    result.Add(reader.Value.ToLower());
                                }
                            }
                        }
                        break;
                }
            }
            return result;
        }


        /// <summary>
        /// Gets a list of files in the given path which match the given extension
        /// </summary>
        /// <param name="path">Path to search in</param>
        /// <param name="extension">Extension to search for. Optional.</param>
        /// <returns>A HashSet<string> containing an entry for each matching file.</returns>
        private StringSet getFileList(string path, string extension = "") {
            StringSet result = new StringSet();
            string lowerExt = extension.ToLower();
            if (Directory.Exists(path)) {
                string[] foundFiles = Directory.GetFiles(path);
                foreach (string fileName in foundFiles) {
                    string lowerName = fileName.ToLower();
                    if (!lowerName.EndsWith(lowerExt))
                        continue;
                    int startPoint = lowerName.LastIndexOf('\\') + 1;
                    int endPoint = lowerName.LastIndexOf('.');
                    lowerName = lowerName.Substring(startPoint, endPoint - startPoint);
                    result.Add(lowerName);
                }
            }
            return result;
        }
    }
}
