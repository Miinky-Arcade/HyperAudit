using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using StringList = System.Collections.Generic.List<string>;

namespace HyperAudit {

    public partial class MainWindow : Form {

        // Colour definitions for use on the table cell formatting
        private Color kColorTextGood = Color.Green;
        private Color kColorTextBad = Color.Red;
        private Color kColorCellGood = Color.LightGreen;
        private Color kColorCellWarning = Color.Orange;
        private Color kColorCellBad = Color.LightPink;

        private Auditor auditor;

        public MainWindow() {
            InitializeComponent();
            auditor = new Auditor(auditData);
            refreshAllAuditData();
        }


        /// <summary>
        /// Refreshes details about all systems for the audit view
        /// </summary>
        private void refreshAllAuditData() {
            try {
                auditor.refreshAllSystems();
                systemDetailsCombo.Items.Clear();
                foreach (string system in auditor.AllSystems) {
                    systemDetailsCombo.Items.Add(system);
                    systemActionsCombo.Items.Add(system);
                }
                systemCountLbl.Text = auditor.AllSystems.Count + " Systems found";
                gameCountLbl.Text = auditor.TotalGameCount + " Games found";
                allSystemsGridView.Refresh();

            } catch (HAException exception) {
                MessageBox.Show(exception.Message);
            }
        }


        /// <summary>
        /// Refreshes the details about a specific system
        /// </summary>
        private void refreshSelectedSystemDetails() {
            if (systemDetailsCombo.SelectedItem == null) {
                MessageBox.Show("You must select a system first");
            } else {
                try {
                    string systemName = systemDetailsCombo.SelectedItem.ToString();
                    auditor.refreshSystemDetails(systemName);
                    detailsGridView.Refresh();
                    updateStatusBar(systemName);

                } catch (HAException exception) {
                    MessageBox.Show(exception.Message);
                }
            }
        }


        /// <summary>
        /// Updates the filter for the details view
        /// </summary>
        private void filterDetailsList(object sender, EventArgs e) {

            // Update checkbox enabled status
            bool checkboxesEnabled = filterCombo.SelectedIndex > 0;
            chkIgnoreTheme.Enabled = checkboxesEnabled;
            chkIgnoreArtwork1.Enabled = checkboxesEnabled;
            chkIgnoreArtwork2.Enabled = checkboxesEnabled;
            chkIgnoreArtwork3.Enabled = checkboxesEnabled;
            chkIgnoreArtwork4.Enabled = checkboxesEnabled;

            string query = "";
            if (filterCombo.SelectedIndex > 0) {
                // Bit of a hack, relies on only being 3 values in list
                bool val = filterCombo.SelectedIndex == 2;
                string op = val ? "AND" : "OR";

                query += "(";
                query += String.Format("ROM='{0}' {1} ", val, op);
                query += String.Format("WheelArt='{0}' {1} ", val, op);
                query += String.Format("Video='{0}' ", val, op);
                query += chkIgnoreTheme.Checked ? "" : String.Format("{0} Theme='{1}' ", op, val);
                query += chkIgnoreArtwork1.Checked ? "" : String.Format("{0} Artwork1='{1}' ", op, val);
                query += chkIgnoreArtwork2.Checked ? "" : String.Format("{0} Artwork2='{1}' ", op, val);
                query += chkIgnoreArtwork3.Checked ? "" : String.Format("{0} Artwork3='{1}' ", op, val);
                query += chkIgnoreArtwork4.Checked ? "" : String.Format("{0} Artwork4='{1}' ", op, val);
                query += ")";
            }
            if (searchField.Text.Length > 0) {
                if (query.Length > 0)
                    query += " AND ";
                query += String.Format("Game LIKE '*{0}*'", searchField.Text);
            }
            detailsSource.Filter = query;
        }


        /// <summary>
        /// Handler for setting the cell style for the all systems audit view.
        /// </summary>
        private void allSystemsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex >= 1 && e.ColumnIndex <= 8) {
                // One of the regular number format columns, work out whether we have any missing files
                // and colour appropriately.
                string val = e.Value.ToString().ToLower();
                string[] parts = val.Split('/');
                int found = int.Parse(parts[0]);
                parts = parts[1].Split(',');
                int total = int.Parse(parts[0]);

                if (found == total) {
                    if (parts.Length > 1) {
                        e.CellStyle.BackColor = kColorCellWarning;
                    } else {
                        e.CellStyle.BackColor = kColorCellGood;
                    }
                } else {
                    e.CellStyle.BackColor = kColorCellBad;
                }

            } else if (e.ColumnIndex >= 9) {
                // Values are true or false in this range
                string val = e.Value.ToString().ToLower();
                if (val == "false") {
                    e.CellStyle.BackColor = kColorCellBad;
                    e.Value = "Missing";
                } else if (val == "true") {
                    e.CellStyle.BackColor = kColorCellGood;
                    e.Value = "Present";
                } else {
                    e.CellStyle.BackColor = kColorCellWarning;
                    e.Value = "Unknown";
                }
            }
        }

        /// <summary>
        /// Handler for setting the cell style for the system details view.
        /// </summary>
        private void detailsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            string val = e.Value.ToString().ToLower();
            if (val == "false") {
                e.CellStyle.BackColor = kColorCellBad;
                e.Value = "Missing";
            } else if (val == "true") {
                e.CellStyle.BackColor = kColorCellGood;
                e.Value = "Present";
            }
        }


        /// <summary>
        /// Updates the statusbar with media counts for the given system
        /// </summary>
        private void updateStatusBar(string systemName) {
            DataRow[] result = auditData.allSystemsTable.Select(String.Format("system = '{0}'", systemName));
            AuditData.allSystemsTableRow systemInfo = (AuditData.allSystemsTableRow)result[0];
            updateStatusLabel(lblDetailsRoms, systemInfo.ROMs, "ROMs");
            updateStatusLabel(lblDetailsWheels, systemInfo.WheelArt, "Wheels");
            updateStatusLabel(lblDetailsVideos, systemInfo.Videos, "Videos");
            updateStatusLabel(lblDetailsThemes, systemInfo.Themes, "Themes");
            updateStatusLabel(lblDetailsArt1, systemInfo.Artwork1, "Art 1");
            updateStatusLabel(lblDetailsArt2, systemInfo.Artwork2, "Art 2");
            updateStatusLabel(lblDetailsArt3, systemInfo.Artwork3, "Art 3");
            updateStatusLabel(lblDetailsArt4, systemInfo.Artwork4, "Art 4");
        }

        /// <summary>
        /// Internal helper function to update a label's value and colour with the result
        /// of a value from the database
        /// </summary>
        /// <param name="lbl">UI Label to be updated</param>
        /// <param name="dataval">Data value from the database</param>
        /// <param name="suffix">Suffix string to append after the item count</param>
        private void updateStatusLabel(Label lbl, string dataval, string suffix) {
            string val = dataval.ToLower();
            string[] parts = val.Split('/');
            int found = int.Parse(parts[0]);
            parts = parts[1].Split(',');
            int total = int.Parse(parts[0]);

            if (found == total) {
                lbl.ForeColor = kColorTextGood;
            } else {
                lbl.ForeColor = kColorTextBad;
            }

            lbl.Text = String.Format("{0}/{1} {2}", found, total, suffix);
        }


        // UI handlers
        private void refreshAllBtn_Click(object sender, EventArgs e) {
            refreshAllAuditData();
        }

        private void refreshDetailsBtn_Click(object sender, EventArgs e) {
            refreshSelectedSystemDetails();
        }

        private void systemDetailsCombo_SelectedIndexChanged(object sender, EventArgs e) {
            refreshSelectedSystemDetails();
        }

        private void btnActionApply_Click(object sender, EventArgs e) {
            MessageBox.Show("Not yet implemented");
        }

        private void btnActionPreview_Click(object sender, EventArgs e) {
            MessageBox.Show("Not yet implemented");
        }
    }
}
