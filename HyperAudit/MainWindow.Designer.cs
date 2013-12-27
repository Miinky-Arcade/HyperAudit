namespace HyperAudit
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.tabpgAudit = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.systemCountLbl = new System.Windows.Forms.Label();
            this.gameCountLbl = new System.Windows.Forms.Label();
            this.allSystemsGridView = new System.Windows.Forms.DataGridView();
            this.systemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOMsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artwork1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artwork2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artwork3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artwork4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wheelArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPointerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customLettersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuWheelArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuThemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuVideoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allSystemsSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditData = new HyperAudit.AuditData();
            this.refreshAllBtn = new System.Windows.Forms.Button();
            this.tabpgDetails = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDetailsRoms = new System.Windows.Forms.Label();
            this.lblDetailsWheels = new System.Windows.Forms.Label();
            this.lblDetailsVideos = new System.Windows.Forms.Label();
            this.lblDetailsThemes = new System.Windows.Forms.Label();
            this.lblDetailsArt1 = new System.Windows.Forms.Label();
            this.lblDetailsArt2 = new System.Windows.Forms.Label();
            this.lblDetailsArt3 = new System.Windows.Forms.Label();
            this.lblDetailsArt4 = new System.Windows.Forms.Label();
            this.chkIgnoreTheme = new System.Windows.Forms.CheckBox();
            this.chkIgnoreArtwork4 = new System.Windows.Forms.CheckBox();
            this.chkIgnoreArtwork3 = new System.Windows.Forms.CheckBox();
            this.chkIgnoreArtwork2 = new System.Windows.Forms.CheckBox();
            this.lblIgnore = new System.Windows.Forms.Label();
            this.chkIgnoreArtwork1 = new System.Windows.Forms.CheckBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.searchField = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.filterCombo = new System.Windows.Forms.ComboBox();
            this.refreshDetailsBtn = new System.Windows.Forms.Button();
            this.detailsGridView = new System.Windows.Forms.DataGridView();
            this.gameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artwork1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artwork2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artwork3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artwork4DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wheelArtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSystem = new System.Windows.Forms.Label();
            this.systemDetailsCombo = new System.Windows.Forms.ComboBox();
            this.tabpgActions = new System.Windows.Forms.TabPage();
            this.mediaTypeCombo = new System.Windows.Forms.ComboBox();
            this.lblMediaType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.systemActionsCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActionApply = new System.Windows.Forms.Button();
            this.actionTypeCombo = new System.Windows.Forms.ComboBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.btnActionPreview = new System.Windows.Forms.Button();
            this.mainTabs.SuspendLayout();
            this.tabpgAudit.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allSystemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allSystemsSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditData)).BeginInit();
            this.tabpgDetails.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsSource)).BeginInit();
            this.tabpgActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabs.Controls.Add(this.tabpgAudit);
            this.mainTabs.Controls.Add(this.tabpgDetails);
            this.mainTabs.Controls.Add(this.tabpgActions);
            this.mainTabs.Location = new System.Drawing.Point(6, 6);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(782, 549);
            this.mainTabs.TabIndex = 0;
            // 
            // tabpgAudit
            // 
            this.tabpgAudit.Controls.Add(this.flowLayoutPanel1);
            this.tabpgAudit.Controls.Add(this.allSystemsGridView);
            this.tabpgAudit.Controls.Add(this.refreshAllBtn);
            this.tabpgAudit.Location = new System.Drawing.Point(4, 22);
            this.tabpgAudit.Name = "tabpgAudit";
            this.tabpgAudit.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgAudit.Size = new System.Drawing.Size(774, 523);
            this.tabpgAudit.TabIndex = 0;
            this.tabpgAudit.Text = "All Systems";
            this.tabpgAudit.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.systemCountLbl);
            this.flowLayoutPanel1.Controls.Add(this.gameCountLbl);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 498);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(687, 22);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // systemCountLbl
            // 
            this.systemCountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.systemCountLbl.AutoSize = true;
            this.systemCountLbl.Location = new System.Drawing.Point(3, 0);
            this.systemCountLbl.Name = "systemCountLbl";
            this.systemCountLbl.Size = new System.Drawing.Size(92, 13);
            this.systemCountLbl.TabIndex = 2;
            this.systemCountLbl.Text = "xx Systems Found";
            // 
            // gameCountLbl
            // 
            this.gameCountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gameCountLbl.AutoSize = true;
            this.gameCountLbl.Location = new System.Drawing.Point(101, 0);
            this.gameCountLbl.Name = "gameCountLbl";
            this.gameCountLbl.Size = new System.Drawing.Size(96, 13);
            this.gameCountLbl.TabIndex = 4;
            this.gameCountLbl.Text = "xxxx Games Found";
            // 
            // allSystemsGridView
            // 
            this.allSystemsGridView.AllowUserToAddRows = false;
            this.allSystemsGridView.AllowUserToDeleteRows = false;
            this.allSystemsGridView.AllowUserToOrderColumns = true;
            this.allSystemsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allSystemsGridView.AutoGenerateColumns = false;
            this.allSystemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.allSystemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allSystemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.systemDataGridViewTextBoxColumn,
            this.rOMsDataGridViewTextBoxColumn,
            this.artwork1DataGridViewTextBoxColumn,
            this.artwork2DataGridViewTextBoxColumn,
            this.artwork3DataGridViewTextBoxColumn,
            this.artwork4DataGridViewTextBoxColumn,
            this.wheelArtDataGridViewTextBoxColumn,
            this.videosDataGridViewTextBoxColumn,
            this.themesDataGridViewTextBoxColumn,
            this.customPointerDataGridViewTextBoxColumn,
            this.customLettersDataGridViewTextBoxColumn,
            this.menuWheelArtDataGridViewTextBoxColumn,
            this.menuThemeDataGridViewTextBoxColumn,
            this.menuVideoDataGridViewTextBoxColumn});
            this.allSystemsGridView.DataSource = this.allSystemsSource;
            this.allSystemsGridView.Location = new System.Drawing.Point(0, 0);
            this.allSystemsGridView.Name = "allSystemsGridView";
            this.allSystemsGridView.ReadOnly = true;
            this.allSystemsGridView.Size = new System.Drawing.Size(774, 488);
            this.allSystemsGridView.TabIndex = 5;
            this.allSystemsGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.allSystemsGridView_CellFormatting);
            // 
            // systemDataGridViewTextBoxColumn
            // 
            this.systemDataGridViewTextBoxColumn.DataPropertyName = "System";
            this.systemDataGridViewTextBoxColumn.HeaderText = "System";
            this.systemDataGridViewTextBoxColumn.Name = "systemDataGridViewTextBoxColumn";
            this.systemDataGridViewTextBoxColumn.ReadOnly = true;
            this.systemDataGridViewTextBoxColumn.Width = 66;
            // 
            // rOMsDataGridViewTextBoxColumn
            // 
            this.rOMsDataGridViewTextBoxColumn.DataPropertyName = "ROMs";
            this.rOMsDataGridViewTextBoxColumn.HeaderText = "ROMs";
            this.rOMsDataGridViewTextBoxColumn.Name = "rOMsDataGridViewTextBoxColumn";
            this.rOMsDataGridViewTextBoxColumn.ReadOnly = true;
            this.rOMsDataGridViewTextBoxColumn.Width = 62;
            // 
            // artwork1DataGridViewTextBoxColumn
            // 
            this.artwork1DataGridViewTextBoxColumn.DataPropertyName = "Artwork1";
            this.artwork1DataGridViewTextBoxColumn.HeaderText = "Artwork1";
            this.artwork1DataGridViewTextBoxColumn.Name = "artwork1DataGridViewTextBoxColumn";
            this.artwork1DataGridViewTextBoxColumn.ReadOnly = true;
            this.artwork1DataGridViewTextBoxColumn.Width = 74;
            // 
            // artwork2DataGridViewTextBoxColumn
            // 
            this.artwork2DataGridViewTextBoxColumn.DataPropertyName = "Artwork2";
            this.artwork2DataGridViewTextBoxColumn.HeaderText = "Artwork2";
            this.artwork2DataGridViewTextBoxColumn.Name = "artwork2DataGridViewTextBoxColumn";
            this.artwork2DataGridViewTextBoxColumn.ReadOnly = true;
            this.artwork2DataGridViewTextBoxColumn.Width = 74;
            // 
            // artwork3DataGridViewTextBoxColumn
            // 
            this.artwork3DataGridViewTextBoxColumn.DataPropertyName = "Artwork3";
            this.artwork3DataGridViewTextBoxColumn.HeaderText = "Artwork3";
            this.artwork3DataGridViewTextBoxColumn.Name = "artwork3DataGridViewTextBoxColumn";
            this.artwork3DataGridViewTextBoxColumn.ReadOnly = true;
            this.artwork3DataGridViewTextBoxColumn.Width = 74;
            // 
            // artwork4DataGridViewTextBoxColumn
            // 
            this.artwork4DataGridViewTextBoxColumn.DataPropertyName = "Artwork4";
            this.artwork4DataGridViewTextBoxColumn.HeaderText = "Artwork4";
            this.artwork4DataGridViewTextBoxColumn.Name = "artwork4DataGridViewTextBoxColumn";
            this.artwork4DataGridViewTextBoxColumn.ReadOnly = true;
            this.artwork4DataGridViewTextBoxColumn.Width = 74;
            // 
            // wheelArtDataGridViewTextBoxColumn
            // 
            this.wheelArtDataGridViewTextBoxColumn.DataPropertyName = "WheelArt";
            this.wheelArtDataGridViewTextBoxColumn.HeaderText = "WheelArt";
            this.wheelArtDataGridViewTextBoxColumn.Name = "wheelArtDataGridViewTextBoxColumn";
            this.wheelArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.wheelArtDataGridViewTextBoxColumn.Width = 76;
            // 
            // videosDataGridViewTextBoxColumn
            // 
            this.videosDataGridViewTextBoxColumn.DataPropertyName = "Videos";
            this.videosDataGridViewTextBoxColumn.HeaderText = "Videos";
            this.videosDataGridViewTextBoxColumn.Name = "videosDataGridViewTextBoxColumn";
            this.videosDataGridViewTextBoxColumn.ReadOnly = true;
            this.videosDataGridViewTextBoxColumn.Width = 64;
            // 
            // themesDataGridViewTextBoxColumn
            // 
            this.themesDataGridViewTextBoxColumn.DataPropertyName = "Themes";
            this.themesDataGridViewTextBoxColumn.HeaderText = "Themes";
            this.themesDataGridViewTextBoxColumn.Name = "themesDataGridViewTextBoxColumn";
            this.themesDataGridViewTextBoxColumn.ReadOnly = true;
            this.themesDataGridViewTextBoxColumn.Width = 70;
            // 
            // customPointerDataGridViewTextBoxColumn
            // 
            this.customPointerDataGridViewTextBoxColumn.DataPropertyName = "CustomPointer";
            this.customPointerDataGridViewTextBoxColumn.HeaderText = "CustomPointer";
            this.customPointerDataGridViewTextBoxColumn.Name = "customPointerDataGridViewTextBoxColumn";
            this.customPointerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customLettersDataGridViewTextBoxColumn
            // 
            this.customLettersDataGridViewTextBoxColumn.DataPropertyName = "CustomLetters";
            this.customLettersDataGridViewTextBoxColumn.HeaderText = "CustomLetters";
            this.customLettersDataGridViewTextBoxColumn.Name = "customLettersDataGridViewTextBoxColumn";
            this.customLettersDataGridViewTextBoxColumn.ReadOnly = true;
            this.customLettersDataGridViewTextBoxColumn.Width = 99;
            // 
            // menuWheelArtDataGridViewTextBoxColumn
            // 
            this.menuWheelArtDataGridViewTextBoxColumn.DataPropertyName = "MenuWheelArt";
            this.menuWheelArtDataGridViewTextBoxColumn.HeaderText = "MenuWheelArt";
            this.menuWheelArtDataGridViewTextBoxColumn.Name = "menuWheelArtDataGridViewTextBoxColumn";
            this.menuWheelArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuWheelArtDataGridViewTextBoxColumn.Width = 103;
            // 
            // menuThemeDataGridViewTextBoxColumn
            // 
            this.menuThemeDataGridViewTextBoxColumn.DataPropertyName = "MenuTheme";
            this.menuThemeDataGridViewTextBoxColumn.HeaderText = "MenuTheme";
            this.menuThemeDataGridViewTextBoxColumn.Name = "menuThemeDataGridViewTextBoxColumn";
            this.menuThemeDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuThemeDataGridViewTextBoxColumn.Width = 92;
            // 
            // menuVideoDataGridViewTextBoxColumn
            // 
            this.menuVideoDataGridViewTextBoxColumn.DataPropertyName = "MenuVideo";
            this.menuVideoDataGridViewTextBoxColumn.HeaderText = "MenuVideo";
            this.menuVideoDataGridViewTextBoxColumn.Name = "menuVideoDataGridViewTextBoxColumn";
            this.menuVideoDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuVideoDataGridViewTextBoxColumn.Width = 86;
            // 
            // allSystemsSource
            // 
            this.allSystemsSource.AllowNew = false;
            this.allSystemsSource.DataMember = "allSystemsTable";
            this.allSystemsSource.DataSource = this.auditData;
            // 
            // auditData
            // 
            this.auditData.DataSetName = "AuditData";
            this.auditData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refreshAllBtn
            // 
            this.refreshAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshAllBtn.Location = new System.Drawing.Point(693, 494);
            this.refreshAllBtn.Name = "refreshAllBtn";
            this.refreshAllBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshAllBtn.TabIndex = 1;
            this.refreshAllBtn.Text = "Refresh";
            this.refreshAllBtn.UseVisualStyleBackColor = true;
            this.refreshAllBtn.Click += new System.EventHandler(this.refreshAllBtn_Click);
            // 
            // tabpgDetails
            // 
            this.tabpgDetails.Controls.Add(this.flowLayoutPanel2);
            this.tabpgDetails.Controls.Add(this.chkIgnoreTheme);
            this.tabpgDetails.Controls.Add(this.chkIgnoreArtwork4);
            this.tabpgDetails.Controls.Add(this.chkIgnoreArtwork3);
            this.tabpgDetails.Controls.Add(this.chkIgnoreArtwork2);
            this.tabpgDetails.Controls.Add(this.lblIgnore);
            this.tabpgDetails.Controls.Add(this.chkIgnoreArtwork1);
            this.tabpgDetails.Controls.Add(this.lblSearch);
            this.tabpgDetails.Controls.Add(this.searchField);
            this.tabpgDetails.Controls.Add(this.lblFilter);
            this.tabpgDetails.Controls.Add(this.filterCombo);
            this.tabpgDetails.Controls.Add(this.refreshDetailsBtn);
            this.tabpgDetails.Controls.Add(this.detailsGridView);
            this.tabpgDetails.Controls.Add(this.lblSystem);
            this.tabpgDetails.Controls.Add(this.systemDetailsCombo);
            this.tabpgDetails.Location = new System.Drawing.Point(4, 22);
            this.tabpgDetails.Name = "tabpgDetails";
            this.tabpgDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgDetails.Size = new System.Drawing.Size(774, 523);
            this.tabpgDetails.TabIndex = 1;
            this.tabpgDetails.Text = "System Details";
            this.tabpgDetails.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.lblDetailsRoms);
            this.flowLayoutPanel2.Controls.Add(this.lblDetailsWheels);
            this.flowLayoutPanel2.Controls.Add(this.lblDetailsVideos);
            this.flowLayoutPanel2.Controls.Add(this.lblDetailsThemes);
            this.flowLayoutPanel2.Controls.Add(this.lblDetailsArt1);
            this.flowLayoutPanel2.Controls.Add(this.lblDetailsArt2);
            this.flowLayoutPanel2.Controls.Add(this.lblDetailsArt3);
            this.flowLayoutPanel2.Controls.Add(this.lblDetailsArt4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 494);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(684, 23);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // lblDetailsRoms
            // 
            this.lblDetailsRoms.AutoSize = true;
            this.lblDetailsRoms.Location = new System.Drawing.Point(3, 0);
            this.lblDetailsRoms.Name = "lblDetailsRoms";
            this.lblDetailsRoms.Size = new System.Drawing.Size(75, 13);
            this.lblDetailsRoms.TabIndex = 0;
            this.lblDetailsRoms.Text = "xxx/xxx ROMs";
            // 
            // lblDetailsWheels
            // 
            this.lblDetailsWheels.AutoSize = true;
            this.lblDetailsWheels.Location = new System.Drawing.Point(84, 0);
            this.lblDetailsWheels.Name = "lblDetailsWheels";
            this.lblDetailsWheels.Size = new System.Drawing.Size(81, 13);
            this.lblDetailsWheels.TabIndex = 1;
            this.lblDetailsWheels.Text = "xxx/xxx Wheels";
            // 
            // lblDetailsVideos
            // 
            this.lblDetailsVideos.AutoSize = true;
            this.lblDetailsVideos.Location = new System.Drawing.Point(171, 0);
            this.lblDetailsVideos.Name = "lblDetailsVideos";
            this.lblDetailsVideos.Size = new System.Drawing.Size(77, 13);
            this.lblDetailsVideos.TabIndex = 2;
            this.lblDetailsVideos.Text = "xxx/xxx Videos";
            // 
            // lblDetailsThemes
            // 
            this.lblDetailsThemes.AutoSize = true;
            this.lblDetailsThemes.Location = new System.Drawing.Point(254, 0);
            this.lblDetailsThemes.Name = "lblDetailsThemes";
            this.lblDetailsThemes.Size = new System.Drawing.Size(83, 13);
            this.lblDetailsThemes.TabIndex = 3;
            this.lblDetailsThemes.Text = "xxx/xxx Themes";
            // 
            // lblDetailsArt1
            // 
            this.lblDetailsArt1.AutoSize = true;
            this.lblDetailsArt1.Location = new System.Drawing.Point(343, 0);
            this.lblDetailsArt1.Name = "lblDetailsArt1";
            this.lblDetailsArt1.Size = new System.Drawing.Size(67, 13);
            this.lblDetailsArt1.TabIndex = 4;
            this.lblDetailsArt1.Text = "xxx/xxx Art 1";
            // 
            // lblDetailsArt2
            // 
            this.lblDetailsArt2.AutoSize = true;
            this.lblDetailsArt2.Location = new System.Drawing.Point(416, 0);
            this.lblDetailsArt2.Name = "lblDetailsArt2";
            this.lblDetailsArt2.Size = new System.Drawing.Size(67, 13);
            this.lblDetailsArt2.TabIndex = 5;
            this.lblDetailsArt2.Text = "xxx/xxx Art 2";
            // 
            // lblDetailsArt3
            // 
            this.lblDetailsArt3.AutoSize = true;
            this.lblDetailsArt3.Location = new System.Drawing.Point(489, 0);
            this.lblDetailsArt3.Name = "lblDetailsArt3";
            this.lblDetailsArt3.Size = new System.Drawing.Size(67, 13);
            this.lblDetailsArt3.TabIndex = 6;
            this.lblDetailsArt3.Text = "xxx/xxx Art 3";
            // 
            // lblDetailsArt4
            // 
            this.lblDetailsArt4.AutoSize = true;
            this.lblDetailsArt4.Location = new System.Drawing.Point(562, 0);
            this.lblDetailsArt4.Name = "lblDetailsArt4";
            this.lblDetailsArt4.Size = new System.Drawing.Size(67, 13);
            this.lblDetailsArt4.TabIndex = 7;
            this.lblDetailsArt4.Text = "xxx/xxx Art 4";
            // 
            // chkIgnoreTheme
            // 
            this.chkIgnoreTheme.AutoSize = true;
            this.chkIgnoreTheme.Enabled = false;
            this.chkIgnoreTheme.Location = new System.Drawing.Point(423, 36);
            this.chkIgnoreTheme.Name = "chkIgnoreTheme";
            this.chkIgnoreTheme.Size = new System.Drawing.Size(59, 17);
            this.chkIgnoreTheme.TabIndex = 14;
            this.chkIgnoreTheme.Text = "Theme";
            this.chkIgnoreTheme.UseVisualStyleBackColor = true;
            this.chkIgnoreTheme.CheckedChanged += new System.EventHandler(this.filterDetailsList);
            // 
            // chkIgnoreArtwork4
            // 
            this.chkIgnoreArtwork4.AutoSize = true;
            this.chkIgnoreArtwork4.Enabled = false;
            this.chkIgnoreArtwork4.Location = new System.Drawing.Point(384, 36);
            this.chkIgnoreArtwork4.Name = "chkIgnoreArtwork4";
            this.chkIgnoreArtwork4.Size = new System.Drawing.Size(32, 17);
            this.chkIgnoreArtwork4.TabIndex = 13;
            this.chkIgnoreArtwork4.Text = "4";
            this.chkIgnoreArtwork4.UseVisualStyleBackColor = true;
            this.chkIgnoreArtwork4.CheckedChanged += new System.EventHandler(this.filterDetailsList);
            // 
            // chkIgnoreArtwork3
            // 
            this.chkIgnoreArtwork3.AutoSize = true;
            this.chkIgnoreArtwork3.Enabled = false;
            this.chkIgnoreArtwork3.Location = new System.Drawing.Point(345, 36);
            this.chkIgnoreArtwork3.Name = "chkIgnoreArtwork3";
            this.chkIgnoreArtwork3.Size = new System.Drawing.Size(32, 17);
            this.chkIgnoreArtwork3.TabIndex = 12;
            this.chkIgnoreArtwork3.Text = "3";
            this.chkIgnoreArtwork3.UseVisualStyleBackColor = true;
            this.chkIgnoreArtwork3.CheckedChanged += new System.EventHandler(this.filterDetailsList);
            // 
            // chkIgnoreArtwork2
            // 
            this.chkIgnoreArtwork2.AutoSize = true;
            this.chkIgnoreArtwork2.Enabled = false;
            this.chkIgnoreArtwork2.Location = new System.Drawing.Point(306, 36);
            this.chkIgnoreArtwork2.Name = "chkIgnoreArtwork2";
            this.chkIgnoreArtwork2.Size = new System.Drawing.Size(32, 17);
            this.chkIgnoreArtwork2.TabIndex = 11;
            this.chkIgnoreArtwork2.Text = "2";
            this.chkIgnoreArtwork2.UseVisualStyleBackColor = true;
            this.chkIgnoreArtwork2.CheckedChanged += new System.EventHandler(this.filterDetailsList);
            // 
            // lblIgnore
            // 
            this.lblIgnore.AutoSize = true;
            this.lblIgnore.Location = new System.Drawing.Point(222, 37);
            this.lblIgnore.Name = "lblIgnore";
            this.lblIgnore.Size = new System.Drawing.Size(40, 13);
            this.lblIgnore.TabIndex = 10;
            this.lblIgnore.Text = "Ignore:";
            // 
            // chkIgnoreArtwork1
            // 
            this.chkIgnoreArtwork1.AutoSize = true;
            this.chkIgnoreArtwork1.Enabled = false;
            this.chkIgnoreArtwork1.Location = new System.Drawing.Point(268, 36);
            this.chkIgnoreArtwork1.Name = "chkIgnoreArtwork1";
            this.chkIgnoreArtwork1.Size = new System.Drawing.Size(32, 17);
            this.chkIgnoreArtwork1.TabIndex = 9;
            this.chkIgnoreArtwork1.Text = "1";
            this.chkIgnoreArtwork1.UseVisualStyleBackColor = true;
            this.chkIgnoreArtwork1.CheckedChanged += new System.EventHandler(this.filterDetailsList);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(495, 37);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search:";
            // 
            // searchField
            // 
            this.searchField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchField.Location = new System.Drawing.Point(545, 33);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(223, 20);
            this.searchField.TabIndex = 7;
            this.searchField.TextChanged += new System.EventHandler(this.filterDetailsList);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(47, 36);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(32, 13);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Filter:";
            // 
            // filterCombo
            // 
            this.filterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterCombo.FormattingEnabled = true;
            this.filterCombo.Items.AddRange(new object[] {
            "Show All",
            "Show Incompletes",
            "Show Completes"});
            this.filterCombo.Location = new System.Drawing.Point(85, 34);
            this.filterCombo.Name = "filterCombo";
            this.filterCombo.Size = new System.Drawing.Size(130, 21);
            this.filterCombo.TabIndex = 5;
            this.filterCombo.SelectedIndexChanged += new System.EventHandler(this.filterDetailsList);
            // 
            // refreshDetailsBtn
            // 
            this.refreshDetailsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshDetailsBtn.Location = new System.Drawing.Point(693, 494);
            this.refreshDetailsBtn.Name = "refreshDetailsBtn";
            this.refreshDetailsBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshDetailsBtn.TabIndex = 3;
            this.refreshDetailsBtn.Text = "Refresh";
            this.refreshDetailsBtn.UseVisualStyleBackColor = true;
            this.refreshDetailsBtn.Click += new System.EventHandler(this.refreshDetailsBtn_Click);
            // 
            // detailsGridView
            // 
            this.detailsGridView.AllowUserToAddRows = false;
            this.detailsGridView.AllowUserToDeleteRows = false;
            this.detailsGridView.AllowUserToOrderColumns = true;
            this.detailsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsGridView.AutoGenerateColumns = false;
            this.detailsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.detailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameDataGridViewTextBoxColumn,
            this.rOMDataGridViewTextBoxColumn,
            this.artwork1DataGridViewTextBoxColumn1,
            this.artwork2DataGridViewTextBoxColumn1,
            this.artwork3DataGridViewTextBoxColumn1,
            this.artwork4DataGridViewTextBoxColumn1,
            this.wheelArtDataGridViewTextBoxColumn1,
            this.videoDataGridViewTextBoxColumn,
            this.themeDataGridViewTextBoxColumn});
            this.detailsGridView.DataSource = this.detailsSource;
            this.detailsGridView.Location = new System.Drawing.Point(0, 61);
            this.detailsGridView.Name = "detailsGridView";
            this.detailsGridView.ReadOnly = true;
            this.detailsGridView.Size = new System.Drawing.Size(774, 427);
            this.detailsGridView.TabIndex = 2;
            this.detailsGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.detailsGridView_CellFormatting);
            // 
            // gameDataGridViewTextBoxColumn
            // 
            this.gameDataGridViewTextBoxColumn.DataPropertyName = "Game";
            this.gameDataGridViewTextBoxColumn.HeaderText = "Game";
            this.gameDataGridViewTextBoxColumn.Name = "gameDataGridViewTextBoxColumn";
            this.gameDataGridViewTextBoxColumn.ReadOnly = true;
            this.gameDataGridViewTextBoxColumn.Width = 60;
            // 
            // rOMDataGridViewTextBoxColumn
            // 
            this.rOMDataGridViewTextBoxColumn.DataPropertyName = "ROM";
            this.rOMDataGridViewTextBoxColumn.HeaderText = "ROM";
            this.rOMDataGridViewTextBoxColumn.Name = "rOMDataGridViewTextBoxColumn";
            this.rOMDataGridViewTextBoxColumn.ReadOnly = true;
            this.rOMDataGridViewTextBoxColumn.Width = 57;
            // 
            // artwork1DataGridViewTextBoxColumn1
            // 
            this.artwork1DataGridViewTextBoxColumn1.DataPropertyName = "Artwork1";
            this.artwork1DataGridViewTextBoxColumn1.HeaderText = "Artwork1";
            this.artwork1DataGridViewTextBoxColumn1.Name = "artwork1DataGridViewTextBoxColumn1";
            this.artwork1DataGridViewTextBoxColumn1.ReadOnly = true;
            this.artwork1DataGridViewTextBoxColumn1.Width = 74;
            // 
            // artwork2DataGridViewTextBoxColumn1
            // 
            this.artwork2DataGridViewTextBoxColumn1.DataPropertyName = "Artwork2";
            this.artwork2DataGridViewTextBoxColumn1.HeaderText = "Artwork2";
            this.artwork2DataGridViewTextBoxColumn1.Name = "artwork2DataGridViewTextBoxColumn1";
            this.artwork2DataGridViewTextBoxColumn1.ReadOnly = true;
            this.artwork2DataGridViewTextBoxColumn1.Width = 74;
            // 
            // artwork3DataGridViewTextBoxColumn1
            // 
            this.artwork3DataGridViewTextBoxColumn1.DataPropertyName = "Artwork3";
            this.artwork3DataGridViewTextBoxColumn1.HeaderText = "Artwork3";
            this.artwork3DataGridViewTextBoxColumn1.Name = "artwork3DataGridViewTextBoxColumn1";
            this.artwork3DataGridViewTextBoxColumn1.ReadOnly = true;
            this.artwork3DataGridViewTextBoxColumn1.Width = 74;
            // 
            // artwork4DataGridViewTextBoxColumn1
            // 
            this.artwork4DataGridViewTextBoxColumn1.DataPropertyName = "Artwork4";
            this.artwork4DataGridViewTextBoxColumn1.HeaderText = "Artwork4";
            this.artwork4DataGridViewTextBoxColumn1.Name = "artwork4DataGridViewTextBoxColumn1";
            this.artwork4DataGridViewTextBoxColumn1.ReadOnly = true;
            this.artwork4DataGridViewTextBoxColumn1.Width = 74;
            // 
            // wheelArtDataGridViewTextBoxColumn1
            // 
            this.wheelArtDataGridViewTextBoxColumn1.DataPropertyName = "WheelArt";
            this.wheelArtDataGridViewTextBoxColumn1.HeaderText = "WheelArt";
            this.wheelArtDataGridViewTextBoxColumn1.Name = "wheelArtDataGridViewTextBoxColumn1";
            this.wheelArtDataGridViewTextBoxColumn1.ReadOnly = true;
            this.wheelArtDataGridViewTextBoxColumn1.Width = 76;
            // 
            // videoDataGridViewTextBoxColumn
            // 
            this.videoDataGridViewTextBoxColumn.DataPropertyName = "Video";
            this.videoDataGridViewTextBoxColumn.HeaderText = "Video";
            this.videoDataGridViewTextBoxColumn.Name = "videoDataGridViewTextBoxColumn";
            this.videoDataGridViewTextBoxColumn.ReadOnly = true;
            this.videoDataGridViewTextBoxColumn.Width = 59;
            // 
            // themeDataGridViewTextBoxColumn
            // 
            this.themeDataGridViewTextBoxColumn.DataPropertyName = "Theme";
            this.themeDataGridViewTextBoxColumn.HeaderText = "Theme";
            this.themeDataGridViewTextBoxColumn.Name = "themeDataGridViewTextBoxColumn";
            this.themeDataGridViewTextBoxColumn.ReadOnly = true;
            this.themeDataGridViewTextBoxColumn.Width = 65;
            // 
            // detailsSource
            // 
            this.detailsSource.AllowNew = false;
            this.detailsSource.DataMember = "detailsTable";
            this.detailsSource.DataSource = this.auditData;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Location = new System.Drawing.Point(35, 9);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(44, 13);
            this.lblSystem.TabIndex = 1;
            this.lblSystem.Text = "System:";
            // 
            // systemDetailsCombo
            // 
            this.systemDetailsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.systemDetailsCombo.FormattingEnabled = true;
            this.systemDetailsCombo.Location = new System.Drawing.Point(85, 6);
            this.systemDetailsCombo.Name = "systemDetailsCombo";
            this.systemDetailsCombo.Size = new System.Drawing.Size(380, 21);
            this.systemDetailsCombo.TabIndex = 0;
            this.systemDetailsCombo.SelectedIndexChanged += new System.EventHandler(this.systemDetailsCombo_SelectedIndexChanged);
            // 
            // tabpgActions
            // 
            this.tabpgActions.Controls.Add(this.btnActionPreview);
            this.tabpgActions.Controls.Add(this.actionTypeCombo);
            this.tabpgActions.Controls.Add(this.lblAction);
            this.tabpgActions.Controls.Add(this.btnActionApply);
            this.tabpgActions.Controls.Add(this.dataGridView1);
            this.tabpgActions.Controls.Add(this.mediaTypeCombo);
            this.tabpgActions.Controls.Add(this.lblMediaType);
            this.tabpgActions.Controls.Add(this.label1);
            this.tabpgActions.Controls.Add(this.systemActionsCombo);
            this.tabpgActions.Location = new System.Drawing.Point(4, 22);
            this.tabpgActions.Name = "tabpgActions";
            this.tabpgActions.Size = new System.Drawing.Size(774, 523);
            this.tabpgActions.TabIndex = 2;
            this.tabpgActions.Text = "System Actions";
            this.tabpgActions.UseVisualStyleBackColor = true;
            // 
            // mediaTypeCombo
            // 
            this.mediaTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mediaTypeCombo.FormattingEnabled = true;
            this.mediaTypeCombo.Items.AddRange(new object[] {
            "ROMs",
            "Wheelart",
            "Videos",
            "Themes",
            "Artwork 1",
            "Artwork 2",
            "Artwork 3",
            "Artwork 4"});
            this.mediaTypeCombo.Location = new System.Drawing.Point(85, 33);
            this.mediaTypeCombo.Name = "mediaTypeCombo";
            this.mediaTypeCombo.Size = new System.Drawing.Size(107, 21);
            this.mediaTypeCombo.TabIndex = 5;
            // 
            // lblMediaType
            // 
            this.lblMediaType.AutoSize = true;
            this.lblMediaType.Location = new System.Drawing.Point(17, 36);
            this.lblMediaType.Name = "lblMediaType";
            this.lblMediaType.Size = new System.Drawing.Size(62, 13);
            this.lblMediaType.TabIndex = 4;
            this.lblMediaType.Text = "Media type:";
            this.lblMediaType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "System:";
            // 
            // systemActionsCombo
            // 
            this.systemActionsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.systemActionsCombo.FormattingEnabled = true;
            this.systemActionsCombo.Location = new System.Drawing.Point(85, 6);
            this.systemActionsCombo.Name = "systemActionsCombo";
            this.systemActionsCombo.Size = new System.Drawing.Size(380, 21);
            this.systemActionsCombo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 428);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnActionApply
            // 
            this.btnActionApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActionApply.Location = new System.Drawing.Point(693, 494);
            this.btnActionApply.Name = "btnActionApply";
            this.btnActionApply.Size = new System.Drawing.Size(75, 23);
            this.btnActionApply.TabIndex = 7;
            this.btnActionApply.Text = "Apply";
            this.btnActionApply.UseVisualStyleBackColor = true;
            this.btnActionApply.Click += new System.EventHandler(this.btnActionApply_Click);
            // 
            // actionTypeCombo
            // 
            this.actionTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionTypeCombo.FormattingEnabled = true;
            this.actionTypeCombo.Items.AddRange(new object[] {
            "List unmatched files",
            "List unmatched ignoring regions/revisions",
            "List unmatched ignoring regions/revisions, excluding Asian/Proto/Beta",
            "Attempt to fill missing files"});
            this.actionTypeCombo.Location = new System.Drawing.Point(282, 33);
            this.actionTypeCombo.Name = "actionTypeCombo";
            this.actionTypeCombo.Size = new System.Drawing.Size(405, 21);
            this.actionTypeCombo.TabIndex = 9;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(239, 37);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(37, 13);
            this.lblAction.TabIndex = 8;
            this.lblAction.Text = "Action";
            // 
            // btnActionPreview
            // 
            this.btnActionPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActionPreview.Location = new System.Drawing.Point(693, 33);
            this.btnActionPreview.Name = "btnActionPreview";
            this.btnActionPreview.Size = new System.Drawing.Size(75, 23);
            this.btnActionPreview.TabIndex = 10;
            this.btnActionPreview.Text = "Preview";
            this.btnActionPreview.UseVisualStyleBackColor = true;
            this.btnActionPreview.Click += new System.EventHandler(this.btnActionPreview_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 561);
            this.Controls.Add(this.mainTabs);
            this.MinimumSize = new System.Drawing.Size(810, 600);
            this.Name = "MainWindow";
            this.Text = "HyperAudit";
            this.mainTabs.ResumeLayout(false);
            this.tabpgAudit.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allSystemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allSystemsSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditData)).EndInit();
            this.tabpgDetails.ResumeLayout(false);
            this.tabpgDetails.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsSource)).EndInit();
            this.tabpgActions.ResumeLayout(false);
            this.tabpgActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage tabpgAudit;
        private System.Windows.Forms.TabPage tabpgDetails;
        private System.Windows.Forms.Button refreshAllBtn;
        private System.Windows.Forms.Label systemCountLbl;
        private System.Windows.Forms.ComboBox systemDetailsCombo;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.DataGridView detailsGridView;
        private System.Windows.Forms.Label gameCountLbl;
        private System.Windows.Forms.Button refreshDetailsBtn;
        private System.Windows.Forms.BindingSource allSystemsSource;
        private System.Windows.Forms.DataGridView allSystemsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOMsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artwork1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artwork2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artwork3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artwork4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wheelArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn themesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customPointerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customLettersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuWheelArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuThemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuVideoDataGridViewTextBoxColumn;
        private AuditData auditData;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox filterCombo;
        private System.Windows.Forms.Label lblIgnore;
        private System.Windows.Forms.CheckBox chkIgnoreArtwork1;
        private System.Windows.Forms.CheckBox chkIgnoreTheme;
        private System.Windows.Forms.CheckBox chkIgnoreArtwork4;
        private System.Windows.Forms.CheckBox chkIgnoreArtwork3;
        private System.Windows.Forms.CheckBox chkIgnoreArtwork2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblDetailsRoms;
        private System.Windows.Forms.Label lblDetailsWheels;
        private System.Windows.Forms.Label lblDetailsVideos;
        private System.Windows.Forms.Label lblDetailsThemes;
        private System.Windows.Forms.Label lblDetailsArt1;
        private System.Windows.Forms.Label lblDetailsArt2;
        private System.Windows.Forms.Label lblDetailsArt3;
        private System.Windows.Forms.Label lblDetailsArt4;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artwork1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artwork2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artwork3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artwork4DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wheelArtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn themeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detailsSource;
        private System.Windows.Forms.TabPage tabpgActions;
        private System.Windows.Forms.ComboBox mediaTypeCombo;
        private System.Windows.Forms.Label lblMediaType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox systemActionsCombo;
        private System.Windows.Forms.ComboBox actionTypeCombo;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Button btnActionApply;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActionPreview;
    }
}

