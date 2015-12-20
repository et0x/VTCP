using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VTCP
{
    public partial class Hashfile_Creator : Form
    {
        public string strRootDir;
        public int numFiles = 0;
        public string algo = "md5";

        public Hashfile_Creator()
        {
            InitializeComponent();
        }

        private void Hashfile_Creator_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void bnChooseRootDir_Click(object sender, EventArgs e)
        {
            DialogResult res = fldHashDirectoryChooser.ShowDialog();

            if (res == DialogResult.OK)
            {
                string folderName = fldHashDirectoryChooser.SelectedPath;
                tbRootDir.Text = folderName;
                bnGenerateList.Enabled = true;
            }
        }

        private void bnGenerateList_Click(object sender, EventArgs e)
        {
            if (cbRecursive.Checked)
            {
                toolStripProgressBar1.Value = 0;
                bnGenerateList.Enabled = false;
                slblStatus.ForeColor = Color.Blue;
                slblStatus.Text = "Counting files, please wait ...";
                fileCount(tbRootDir.Text, tbFilter.Text, true);
                toolStripStatusLabel1.Text = "Count: " + numFiles.ToString();
                toolStripProgressBar1.Maximum = numFiles;
                slblStatus.Text = "Calculating all hashes, please wait ...";
                fileSearch(tbRootDir.Text, tbFilter.Text, true);
                bnGenerateList.Enabled = true;
                slblStatus.ForeColor = Color.Green;
                slblStatus.Text = "Done!";
                numFiles = 0;

            }
            if (lbResults.Items.Count != 0)
            {
                bnSaveList.Enabled = true;
            }
        }

        void fileSearch(string rootDir, string filter, bool recursive)
        {
            if (recursive)
            {
                try
                {
                    foreach (string dir in Directory.GetDirectories(rootDir))
                    {
                        foreach (string file in Directory.GetFiles(dir,filter))
                        {
                            toolStripProgressBar1.Value++;
                            Hasher h = new Hasher(file, algo);
                            lbResults.Items.Add(h.calculateHash() + "|" + file);
                        }

                        fileSearch(dir, filter,false);
                    }
                }
                catch (Exception ex)
                {
                    // do something
                }
            }
            else
            {
                try
                {
                    foreach (string dir in Directory.GetDirectories(rootDir))
                    {
                        
                        foreach (string file in Directory.GetFiles(dir, filter))
                        {
                            toolStripProgressBar1.Value++;
                            Hasher h = new Hasher(file, algo);
                            lbResults.Items.Add(h.calculateHash() + "|" + file);
                        }

                    }
                }
                catch (Exception ex)
                {
                    // do something
                }
            }
        }
        void fileCount(string rootDir, string filter, bool recursive)
        {
            if (recursive)
            {

                foreach (string dir in Directory.GetDirectories(rootDir))
                {
                    try
                    {
                        foreach (string file in Directory.GetFiles(dir, filter))
                        {
                            numFiles++;
                        }

                        fileCount(dir, filter, true);
                    }
                    catch (Exception ex)
                    {
                        // do nothing
                    }
                }

            }
            else
            {
                foreach (string dir in Directory.GetDirectories(rootDir))
                {
                    try
                    {
                        foreach (string file in Directory.GetFiles(dir, filter))
                        {
                            numFiles++;
                        }
                    }
                    catch (Exception ex)
                    {
                        // do something
                    }

                }
            }
        }

        private void rbMD5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMD5.Checked)
            {
                algo = "md5";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           if (rbSHA1.Checked)
            {
                algo = "sha1";
            }
        }

        private void rbSHA256_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSHA256.Checked)
            {
                algo = "sha256";
            }
        }

        private void bnSaveList_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "Txt files (*.txt)|*.txt";
            saveFileDialog1.RestoreDirectory = true;
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter s = new StreamWriter(saveFileDialog1.FileName);
                foreach (var item in lbResults.Items)
                {
                    s.WriteLine(item.ToString());
                }
                s.Close();
            }
        }
    }
}
