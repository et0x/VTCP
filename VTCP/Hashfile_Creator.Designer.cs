namespace VTCP
{
    partial class Hashfile_Creator
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
            this.fldHashDirectoryChooser = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRootDir = new System.Windows.Forms.TextBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbRecursive = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.bnChooseRootDir = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bnGenerateList = new System.Windows.Forms.Button();
            this.bnSaveList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSHA256 = new System.Windows.Forms.RadioButton();
            this.rbSHA1 = new System.Windows.Forms.RadioButton();
            this.rbMD5 = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Root Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filter:";
            // 
            // tbRootDir
            // 
            this.tbRootDir.Location = new System.Drawing.Point(102, 14);
            this.tbRootDir.Name = "tbRootDir";
            this.tbRootDir.ReadOnly = true;
            this.tbRootDir.Size = new System.Drawing.Size(210, 20);
            this.tbRootDir.TabIndex = 2;
            // 
            // tbFilter
            // 
            this.tbFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(102, 36);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(210, 21);
            this.tbFilter.TabIndex = 3;
            this.tbFilter.Text = "*.exe";
            // 
            // cbRecursive
            // 
            this.cbRecursive.AutoSize = true;
            this.cbRecursive.Checked = true;
            this.cbRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRecursive.Location = new System.Drawing.Point(320, 88);
            this.cbRecursive.Name = "cbRecursive";
            this.cbRecursive.Size = new System.Drawing.Size(113, 17);
            this.cbRecursive.TabIndex = 4;
            this.cbRecursive.Text = "Recursive Lookup";
            this.cbRecursive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbResults);
            this.groupBox1.Location = new System.Drawing.Point(21, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 239);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.HorizontalScrollbar = true;
            this.lbResults.Location = new System.Drawing.Point(13, 21);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(382, 199);
            this.lbResults.TabIndex = 0;
            // 
            // bnChooseRootDir
            // 
            this.bnChooseRootDir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnChooseRootDir.Location = new System.Drawing.Point(316, 14);
            this.bnChooseRootDir.Name = "bnChooseRootDir";
            this.bnChooseRootDir.Size = new System.Drawing.Size(111, 43);
            this.bnChooseRootDir.TabIndex = 6;
            this.bnChooseRootDir.Text = "Choose";
            this.bnChooseRootDir.UseVisualStyleBackColor = true;
            this.bnChooseRootDir.Click += new System.EventHandler(this.bnChooseRootDir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.slblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(445, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(175, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel1.Text = "Count: 0";
            // 
            // bnGenerateList
            // 
            this.bnGenerateList.Enabled = false;
            this.bnGenerateList.Location = new System.Drawing.Point(21, 366);
            this.bnGenerateList.Name = "bnGenerateList";
            this.bnGenerateList.Size = new System.Drawing.Size(202, 32);
            this.bnGenerateList.TabIndex = 8;
            this.bnGenerateList.Text = "Generate List";
            this.bnGenerateList.UseVisualStyleBackColor = true;
            this.bnGenerateList.Click += new System.EventHandler(this.bnGenerateList_Click);
            // 
            // bnSaveList
            // 
            this.bnSaveList.Enabled = false;
            this.bnSaveList.Location = new System.Drawing.Point(229, 366);
            this.bnSaveList.Name = "bnSaveList";
            this.bnSaveList.Size = new System.Drawing.Size(200, 32);
            this.bnSaveList.TabIndex = 9;
            this.bnSaveList.Text = "Save List";
            this.bnSaveList.UseVisualStyleBackColor = true;
            this.bnSaveList.Click += new System.EventHandler(this.bnSaveList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSHA256);
            this.groupBox2.Controls.Add(this.rbSHA1);
            this.groupBox2.Controls.Add(this.rbMD5);
            this.groupBox2.Location = new System.Drawing.Point(21, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 45);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algorithm";
            // 
            // rbSHA256
            // 
            this.rbSHA256.AutoSize = true;
            this.rbSHA256.Location = new System.Drawing.Point(208, 18);
            this.rbSHA256.Name = "rbSHA256";
            this.rbSHA256.Size = new System.Drawing.Size(65, 17);
            this.rbSHA256.TabIndex = 2;
            this.rbSHA256.Text = "SHA256";
            this.rbSHA256.UseVisualStyleBackColor = true;
            this.rbSHA256.CheckedChanged += new System.EventHandler(this.rbSHA256_CheckedChanged);
            // 
            // rbSHA1
            // 
            this.rbSHA1.AutoSize = true;
            this.rbSHA1.Location = new System.Drawing.Point(117, 18);
            this.rbSHA1.Name = "rbSHA1";
            this.rbSHA1.Size = new System.Drawing.Size(53, 17);
            this.rbSHA1.TabIndex = 1;
            this.rbSHA1.Text = "SHA1";
            this.rbSHA1.UseVisualStyleBackColor = true;
            this.rbSHA1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbMD5
            // 
            this.rbMD5.AutoSize = true;
            this.rbMD5.Checked = true;
            this.rbMD5.Location = new System.Drawing.Point(12, 19);
            this.rbMD5.Name = "rbMD5";
            this.rbMD5.Size = new System.Drawing.Size(48, 17);
            this.rbMD5.TabIndex = 0;
            this.rbMD5.TabStop = true;
            this.rbMD5.Text = "MD5";
            this.rbMD5.UseVisualStyleBackColor = true;
            this.rbMD5.CheckedChanged += new System.EventHandler(this.rbMD5_CheckedChanged);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel2.Text = "Status:";
            // 
            // slblStatus
            // 
            this.slblStatus.ForeColor = System.Drawing.Color.Red;
            this.slblStatus.Name = "slblStatus";
            this.slblStatus.Size = new System.Drawing.Size(52, 17);
            this.slblStatus.Text = "Disabled";
            // 
            // Hashfile_Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bnSaveList);
            this.Controls.Add(this.bnGenerateList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bnChooseRootDir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbRecursive);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.tbRootDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Hashfile_Creator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hashfile Creator";
            this.Load += new System.EventHandler(this.Hashfile_Creator_Load);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fldHashDirectoryChooser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRootDir;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.CheckBox cbRecursive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button bnChooseRootDir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button bnGenerateList;
        private System.Windows.Forms.Button bnSaveList;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSHA256;
        private System.Windows.Forms.RadioButton rbSHA1;
        private System.Windows.Forms.RadioButton rbMD5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel slblStatus;
    }
}