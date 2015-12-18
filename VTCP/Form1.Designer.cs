namespace VTCP
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.bnAddApiKey = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbAddApiKey = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbHashes = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bnSubmit = new System.Windows.Forms.Button();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPIKeysFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA256ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPIKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashfileGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDetectionThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProjectedDay = new System.Windows.Forms.Label();
            this.lblPrjDay = new System.Windows.Forms.Label();
            this.lblPrjHr = new System.Windows.Forms.Label();
            this.lblProjectedHr = new System.Windows.Forms.Label();
            this.lblIntSec = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblPrj2 = new System.Windows.Forms.Label();
            this.lblProjectedMin = new System.Windows.Forms.Label();
            this.lblPrj = new System.Windows.Forms.Label();
            this.lbApiKeys = new System.Windows.Forms.ListBox();
            this.mnulbApiKey = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHashListbox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbVerbose = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mnulbApiKey.SuspendLayout();
            this.mnuHashListbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "API KEY:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bnAddApiKey
            // 
            this.bnAddApiKey.Enabled = false;
            this.bnAddApiKey.Location = new System.Drawing.Point(12, 438);
            this.bnAddApiKey.Name = "bnAddApiKey";
            this.bnAddApiKey.Size = new System.Drawing.Size(231, 26);
            this.bnAddApiKey.TabIndex = 3;
            this.bnAddApiKey.Text = "Add API Key";
            this.bnAddApiKey.UseVisualStyleBackColor = true;
            this.bnAddApiKey.Click += new System.EventHandler(this.bnAddApiKey_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Load API Keys From File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbAddApiKey
            // 
            this.tbAddApiKey.Location = new System.Drawing.Point(69, 411);
            this.tbAddApiKey.Name = "tbAddApiKey";
            this.tbAddApiKey.Size = new System.Drawing.Size(173, 20);
            this.tbAddApiKey.TabIndex = 5;
            this.tbAddApiKey.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(253, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(671, 427);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbHashes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hashes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbHashes
            // 
            this.lbHashes.ContextMenuStrip = this.mnuHashListbox;
            this.lbHashes.FormattingEnabled = true;
            this.lbHashes.Location = new System.Drawing.Point(10, 7);
            this.lbHashes.Name = "lbHashes";
            this.lbHashes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbHashes.Size = new System.Drawing.Size(642, 381);
            this.lbHashes.TabIndex = 0;
            this.lbHashes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbVerbose);
            this.tabPage2.Controls.Add(this.bnSubmit);
            this.tabPage2.Controls.Add(this.tbHash);
            this.tabPage2.Controls.Add(this.rtbResults);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(663, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Results";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bnSubmit
            // 
            this.bnSubmit.Location = new System.Drawing.Point(505, 374);
            this.bnSubmit.Name = "bnSubmit";
            this.bnSubmit.Size = new System.Drawing.Size(76, 21);
            this.bnSubmit.TabIndex = 2;
            this.bnSubmit.Text = "Submit";
            this.bnSubmit.UseVisualStyleBackColor = true;
            this.bnSubmit.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbHash
            // 
            this.tbHash.Location = new System.Drawing.Point(6, 375);
            this.tbHash.Name = "tbHash";
            this.tbHash.Size = new System.Drawing.Size(493, 20);
            this.tbHash.TabIndex = 1;
            // 
            // rtbResults
            // 
            this.rtbResults.BackColor = System.Drawing.Color.Black;
            this.rtbResults.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(236)))));
            this.rtbResults.Location = new System.Drawing.Point(6, 6);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(651, 362);
            this.rtbResults.TabIndex = 0;
            this.rtbResults.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(255, 472);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(883, 21);
            this.progressBar1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1145, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aPIKeysFileToolStripMenuItem,
            this.hashFileToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // aPIKeysFileToolStripMenuItem
            // 
            this.aPIKeysFileToolStripMenuItem.Name = "aPIKeysFileToolStripMenuItem";
            this.aPIKeysFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aPIKeysFileToolStripMenuItem.Text = "API Keys File";
            this.aPIKeysFileToolStripMenuItem.Click += new System.EventHandler(this.aPIKeysFileToolStripMenuItem_Click);
            // 
            // hashFileToolStripMenuItem
            // 
            this.hashFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mD5ToolStripMenuItem,
            this.sHA1ToolStripMenuItem,
            this.sHA256ToolStripMenuItem});
            this.hashFileToolStripMenuItem.Name = "hashFileToolStripMenuItem";
            this.hashFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hashFileToolStripMenuItem.Text = "Hash File";
            // 
            // mD5ToolStripMenuItem
            // 
            this.mD5ToolStripMenuItem.Name = "mD5ToolStripMenuItem";
            this.mD5ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mD5ToolStripMenuItem.Text = "MD5";
            // 
            // sHA1ToolStripMenuItem
            // 
            this.sHA1ToolStripMenuItem.Name = "sHA1ToolStripMenuItem";
            this.sHA1ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.sHA1ToolStripMenuItem.Text = "SHA1";
            // 
            // sHA256ToolStripMenuItem
            // 
            this.sHA256ToolStripMenuItem.Name = "sHA256ToolStripMenuItem";
            this.sHA256ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.sHA256ToolStripMenuItem.Text = "SHA256";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aPIKeysToolStripMenuItem,
            this.hashesToolStripMenuItem});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // aPIKeysToolStripMenuItem
            // 
            this.aPIKeysToolStripMenuItem.Name = "aPIKeysToolStripMenuItem";
            this.aPIKeysToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.aPIKeysToolStripMenuItem.Text = "API Keys";
            this.aPIKeysToolStripMenuItem.Click += new System.EventHandler(this.aPIKeysToolStripMenuItem_Click);
            // 
            // hashesToolStripMenuItem
            // 
            this.hashesToolStripMenuItem.Name = "hashesToolStripMenuItem";
            this.hashesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hashesToolStripMenuItem.Text = "Hashes";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.hashfileGeneratorToolStripMenuItem,
            this.toolStripMenuItem2,
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // hashfileGeneratorToolStripMenuItem
            // 
            this.hashfileGeneratorToolStripMenuItem.Name = "hashfileGeneratorToolStripMenuItem";
            this.hashfileGeneratorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.hashfileGeneratorToolStripMenuItem.Text = "Hashfile Generator";
            this.hashfileGeneratorToolStripMenuItem.Click += new System.EventHandler(this.hashfileGeneratorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(169, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDetectionThresholdToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setDetectionThresholdToolStripMenuItem
            // 
            this.setDetectionThresholdToolStripMenuItem.Name = "setDetectionThresholdToolStripMenuItem";
            this.setDetectionThresholdToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.setDetectionThresholdToolStripMenuItem.Text = "Detection Threshold: 10";
            this.setDetectionThresholdToolStripMenuItem.Click += new System.EventHandler(this.setDetectionThresholdToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProjectedDay);
            this.groupBox1.Controls.Add(this.lblPrjDay);
            this.groupBox1.Controls.Add(this.lblPrjHr);
            this.groupBox1.Controls.Add(this.lblProjectedHr);
            this.groupBox1.Controls.Add(this.lblIntSec);
            this.groupBox1.Controls.Add(this.lblInterval);
            this.groupBox1.Controls.Add(this.lblInt);
            this.groupBox1.Controls.Add(this.lblPrj2);
            this.groupBox1.Controls.Add(this.lblProjectedMin);
            this.groupBox1.Controls.Add(this.lblPrj);
            this.groupBox1.Location = new System.Drawing.Point(927, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 422);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rate Monitor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblProjectedDay
            // 
            this.lblProjectedDay.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblProjectedDay.AutoSize = true;
            this.lblProjectedDay.Location = new System.Drawing.Point(87, 48);
            this.lblProjectedDay.Name = "lblProjectedDay";
            this.lblProjectedDay.Size = new System.Drawing.Size(13, 13);
            this.lblProjectedDay.TabIndex = 9;
            this.lblProjectedDay.Text = "0";
            // 
            // lblPrjDay
            // 
            this.lblPrjDay.AutoSize = true;
            this.lblPrjDay.Location = new System.Drawing.Point(124, 48);
            this.lblPrjDay.Name = "lblPrjDay";
            this.lblPrjDay.Size = new System.Drawing.Size(31, 13);
            this.lblPrjDay.TabIndex = 8;
            this.lblPrjDay.Text = "/Day";
            // 
            // lblPrjHr
            // 
            this.lblPrjHr.AutoSize = true;
            this.lblPrjHr.Location = new System.Drawing.Point(126, 35);
            this.lblPrjHr.Name = "lblPrjHr";
            this.lblPrjHr.Size = new System.Drawing.Size(23, 13);
            this.lblPrjHr.TabIndex = 7;
            this.lblPrjHr.Text = "/Hr";
            // 
            // lblProjectedHr
            // 
            this.lblProjectedHr.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblProjectedHr.AutoSize = true;
            this.lblProjectedHr.Location = new System.Drawing.Point(87, 35);
            this.lblProjectedHr.Name = "lblProjectedHr";
            this.lblProjectedHr.Size = new System.Drawing.Size(13, 13);
            this.lblProjectedHr.TabIndex = 6;
            this.lblProjectedHr.Text = "0";
            // 
            // lblIntSec
            // 
            this.lblIntSec.AutoSize = true;
            this.lblIntSec.Location = new System.Drawing.Point(106, 69);
            this.lblIntSec.Name = "lblIntSec";
            this.lblIntSec.Size = new System.Drawing.Size(49, 13);
            this.lblIntSec.TabIndex = 5;
            this.lblIntSec.Text = "Seconds";
            // 
            // lblInterval
            // 
            this.lblInterval.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblInterval.Location = new System.Drawing.Point(87, 69);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(24, 13);
            this.lblInterval.TabIndex = 4;
            this.lblInterval.Text = "NA";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(8, 69);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(78, 13);
            this.lblInt.TabIndex = 3;
            this.lblInt.Text = "Interval Pause:";
            // 
            // lblPrj2
            // 
            this.lblPrj2.AutoSize = true;
            this.lblPrj2.Location = new System.Drawing.Point(126, 22);
            this.lblPrj2.Name = "lblPrj2";
            this.lblPrj2.Size = new System.Drawing.Size(29, 13);
            this.lblPrj2.TabIndex = 2;
            this.lblPrj2.Text = "/Min";
            // 
            // lblProjectedMin
            // 
            this.lblProjectedMin.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblProjectedMin.AutoSize = true;
            this.lblProjectedMin.Location = new System.Drawing.Point(87, 22);
            this.lblProjectedMin.Name = "lblProjectedMin";
            this.lblProjectedMin.Size = new System.Drawing.Size(13, 13);
            this.lblProjectedMin.TabIndex = 1;
            this.lblProjectedMin.Text = "0";
            // 
            // lblPrj
            // 
            this.lblPrj.AutoSize = true;
            this.lblPrj.Location = new System.Drawing.Point(8, 22);
            this.lblPrj.Name = "lblPrj";
            this.lblPrj.Size = new System.Drawing.Size(55, 13);
            this.lblPrj.TabIndex = 0;
            this.lblPrj.Text = "Projected:";
            // 
            // lbApiKeys
            // 
            this.lbApiKeys.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApiKeys.FormattingEnabled = true;
            this.lbApiKeys.HorizontalScrollbar = true;
            this.lbApiKeys.Location = new System.Drawing.Point(16, 37);
            this.lbApiKeys.Name = "lbApiKeys";
            this.lbApiKeys.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbApiKeys.Size = new System.Drawing.Size(226, 368);
            this.lbApiKeys.TabIndex = 10;
            this.lbApiKeys.SelectedIndexChanged += new System.EventHandler(this.lbApiKeys_SelectedIndexChanged);
            // 
            // mnulbApiKey
            // 
            this.mnulbApiKey.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripSeparator1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.mnulbApiKey.Name = "mnulbApiKey";
            this.mnulbApiKey.Size = new System.Drawing.Size(186, 76);
            this.mnulbApiKey.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem3.Text = "Load API Key List File";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem4.Text = "Remove Item(s)";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem5.Text = "Clear All";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // mnuHashListbox
            // 
            this.mnuHashListbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripSeparator2,
            this.toolStripMenuItem8});
            this.mnuHashListbox.Name = "mnuHashListbox";
            this.mnuHashListbox.Size = new System.Drawing.Size(158, 76);
            this.mnuHashListbox.Opening += new System.ComponentModel.CancelEventHandler(this.mnuHashListbox_Opening);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem6.Text = "Load Hashes";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem7.Text = "Remove Item(s)";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem8.Text = "Clear Item(s)";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbVerbose
            // 
            this.cbVerbose.AutoSize = true;
            this.cbVerbose.Location = new System.Drawing.Point(587, 377);
            this.cbVerbose.Name = "cbVerbose";
            this.cbVerbose.Size = new System.Drawing.Size(65, 17);
            this.cbVerbose.TabIndex = 3;
            this.cbVerbose.Text = "Verbose";
            this.cbVerbose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 502);
            this.Controls.Add(this.lbApiKeys);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbAddApiKey);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bnAddApiKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "651 CPT Virus Total Command Post";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mnulbApiKey.ResumeLayout(false);
            this.mnuHashListbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnAddApiKey;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbAddApiKey;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPIKeysFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mD5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHA1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHA256ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPIKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Button bnSubmit;
        private System.Windows.Forms.TextBox tbHash;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label lblPrj2;
        private System.Windows.Forms.Label lblProjectedMin;
        private System.Windows.Forms.Label lblPrj;
        private System.Windows.Forms.Label lblIntSec;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.ListBox lbApiKeys;
        private System.Windows.Forms.Label lblPrjHr;
        private System.Windows.Forms.Label lblProjectedHr;
        private System.Windows.Forms.Label lblProjectedDay;
        private System.Windows.Forms.Label lblPrjDay;
        private System.Windows.Forms.ContextMenuStrip mnulbApiKey;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ListBox lbHashes;
        private System.Windows.Forms.ToolStripMenuItem setDetectionThresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashfileGeneratorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mnuHashListbox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbVerbose;
    }
}

