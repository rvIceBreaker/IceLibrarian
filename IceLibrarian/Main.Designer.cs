namespace IceLibrarian
{
    partial class Main
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.fileNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LengthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArtistHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AlbumHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filenameText = new System.Windows.Forms.TextBox();
            this.albumText = new System.Windows.Forms.TextBox();
            this.artistText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyTagChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggregateSongsToLibraryDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateFileNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressStatusBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.librarycountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.librarychangedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trackNumTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameHeader,
            this.NameHeader,
            this.LengthHeader,
            this.ArtistHeader,
            this.AlbumHeader,
            this.TrackNumber});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(753, 346);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // fileNameHeader
            // 
            this.fileNameHeader.Text = "File Name";
            this.fileNameHeader.Width = 350;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 150;
            // 
            // LengthHeader
            // 
            this.LengthHeader.Text = "Length";
            this.LengthHeader.Width = 45;
            // 
            // ArtistHeader
            // 
            this.ArtistHeader.Text = "Artist";
            this.ArtistHeader.Width = 133;
            // 
            // AlbumHeader
            // 
            this.AlbumHeader.Text = "Album";
            this.AlbumHeader.Width = 157;
            // 
            // TrackNumber
            // 
            this.TrackNumber.Text = "Track #";
            this.TrackNumber.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.trackNumTextbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.filenameText);
            this.groupBox1.Controls.Add(this.albumText);
            this.groupBox1.Controls.Add(this.artistText);
            this.groupBox1.Controls.Add(this.titleText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(771, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Song Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "File Name: ";
            // 
            // filenameText
            // 
            this.filenameText.Location = new System.Drawing.Point(6, 40);
            this.filenameText.Name = "filenameText";
            this.filenameText.Size = new System.Drawing.Size(188, 20);
            this.filenameText.TabIndex = 6;
            // 
            // albumText
            // 
            this.albumText.Location = new System.Drawing.Point(6, 157);
            this.albumText.Name = "albumText";
            this.albumText.Size = new System.Drawing.Size(188, 20);
            this.albumText.TabIndex = 5;
            // 
            // artistText
            // 
            this.artistText.Location = new System.Drawing.Point(6, 118);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(188, 20);
            this.artistText.TabIndex = 4;
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(6, 79);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(188, 20);
            this.titleText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Album: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFileToolStripMenuItem,
            this.importFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importFileToolStripMenuItem
            // 
            this.importFileToolStripMenuItem.Name = "importFileToolStripMenuItem";
            this.importFileToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.importFileToolStripMenuItem.Text = "Import File...";
            this.importFileToolStripMenuItem.Click += new System.EventHandler(this.importFileToolStripMenuItem_Click);
            // 
            // importFolderToolStripMenuItem
            // 
            this.importFolderToolStripMenuItem.Name = "importFolderToolStripMenuItem";
            this.importFolderToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.importFolderToolStripMenuItem.Text = "Import Folder...";
            this.importFolderToolStripMenuItem.Click += new System.EventHandler(this.importFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyTagChangesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // applyTagChangesToolStripMenuItem
            // 
            this.applyTagChangesToolStripMenuItem.Name = "applyTagChangesToolStripMenuItem";
            this.applyTagChangesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.applyTagChangesToolStripMenuItem.Text = "Apply Tag Changes";
            this.applyTagChangesToolStripMenuItem.Click += new System.EventHandler(this.applyTagChangesToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggregateSongsToLibraryDirectoryToolStripMenuItem,
            this.generateFileNameToolStripMenuItem,
            this.toolStripSeparator2,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // aggregateSongsToLibraryDirectoryToolStripMenuItem
            // 
            this.aggregateSongsToLibraryDirectoryToolStripMenuItem.Name = "aggregateSongsToLibraryDirectoryToolStripMenuItem";
            this.aggregateSongsToLibraryDirectoryToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.aggregateSongsToLibraryDirectoryToolStripMenuItem.Text = "Aggregate Songs to Library Directory";
            // 
            // generateFileNameToolStripMenuItem
            // 
            this.generateFileNameToolStripMenuItem.Name = "generateFileNameToolStripMenuItem";
            this.generateFileNameToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.generateFileNameToolStripMenuItem.Text = "Generate File Name(s)";
            this.generateFileNameToolStripMenuItem.Click += new System.EventHandler(this.generateFileNameToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(265, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.optionsToolStripMenuItem.Text = "Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "MP3 Files|*.mp3|All Files|*.*";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.progressStatusBar,
            this.toolStripStatusLabel1,
            this.librarycountLabel,
            this.librarychangedLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(983, 24);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 19);
            this.statusLabel.Text = "status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressStatusBar
            // 
            this.progressStatusBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressStatusBar.Name = "progressStatusBar";
            this.progressStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressStatusBar.Size = new System.Drawing.Size(100, 18);
            this.progressStatusBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressStatusBar.Value = 50;
            this.progressStatusBar.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(690, 19);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // librarycountLabel
            // 
            this.librarycountLabel.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.librarycountLabel.Margin = new System.Windows.Forms.Padding(0, 3, 50, 2);
            this.librarycountLabel.Name = "librarycountLabel";
            this.librarycountLabel.Size = new System.Drawing.Size(62, 19);
            this.librarycountLabel.Text = "LibraryCnt";
            // 
            // librarychangedLabel
            // 
            this.librarychangedLabel.Margin = new System.Windows.Forms.Padding(0, 3, 50, 2);
            this.librarychangedLabel.Name = "librarychangedLabel";
            this.librarychangedLabel.Size = new System.Drawing.Size(74, 19);
            this.librarychangedLabel.Text = "ChangedCnt";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // trackNumTextbox
            // 
            this.trackNumTextbox.Location = new System.Drawing.Point(6, 196);
            this.trackNumTextbox.Name = "trackNumTextbox";
            this.trackNumTextbox.Size = new System.Drawing.Size(188, 20);
            this.trackNumTextbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Track #: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 398);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "IceLibrarian";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader LengthHeader;
        private System.Windows.Forms.ColumnHeader ArtistHeader;
        private System.Windows.Forms.ColumnHeader AlbumHeader;
        private System.Windows.Forms.ColumnHeader TrackNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateFileNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader fileNameHeader;
        private System.Windows.Forms.TextBox albumText;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filenameText;
        private System.Windows.Forms.ToolStripMenuItem aggregateSongsToLibraryDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyTagChangesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel librarycountLabel;
        private System.Windows.Forms.ToolStripProgressBar progressStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel librarychangedLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox trackNumTextbox;
        private System.Windows.Forms.Label label5;
    }
}

