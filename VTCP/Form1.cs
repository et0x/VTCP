using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace VTCP
{
    public partial class Form1 : Form
    {
        VirusTotalHandler handler = new VirusTotalHandler();
        RTBPrinter rtb = new RTBPrinter();
        int detectionThreshold = 10;
        int apiKeyIndex = 0;
        int hashIndex = 0;

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (runToolStripMenuItem.Checked)
            {
                runToolStripMenuItem.Checked = false;
                timer1.Enabled = false;
                apiKeyIndex = 0;
                hashIndex = 0;
                tbHash.Enabled = true;
            }
            else
            {
                // Insert code to start VT Submissions here
                tbHash.Enabled = false;
                timer1.Enabled = true;
                runToolStripMenuItem.Checked = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Insert code to stop VT Submissions here if they are running
            System.Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbApiKeys.ContextMenuStrip = mnulbApiKey;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbHash.Text.Trim() != "")
            {
                handler.APIKey = lbApiKeys.Items[apiKeyIndex].ToString();
                string json = handler.CheckHash(tbHash.Text);

                // rtbResults.Text = json;
                VirusTotalResults res = JsonConvert.DeserializeObject<VirusTotalResults>(json);
                if (res.positives >= detectionThreshold)
                {
                    rtb.printFailure("Detections for '" + res.md5 + "': " + res.positives + " / " + res.total, rtbResults);
                    if (cbVerbose.Checked)
                    {
                        rtb.printStatus("  APIKey: " + handler.APIKey, rtbResults);
                        rtb.printStatus("  File:   " + System.IO.Path.GetFileName(lbHashes.Items[hashIndex].ToString().Split('|')[1]), rtbResults);
                    }
                }
                else
                {
                    rtb.printSuccess("Detections for '" + res.md5 + "': " + res.positives + " / " + res.total, rtbResults);
                    if (cbVerbose.Checked)
                    {
                        rtb.printStatus("  APIKey: " + handler.APIKey, rtbResults);
                        rtb.printStatus("  File:   " + System.IO.Path.GetFileName(lbHashes.Items[hashIndex].ToString().Split('|')[1]), rtbResults);
                    }
                }
                if (apiKeyIndex + 1 >= lbApiKeys.Items.Count)
                {
                    apiKeyIndex = 0;
                } 
                else
                {
                    apiKeyIndex++;
                }

                rtbResults.SelectionStart = rtbResults.Text.Length;
                rtbResults.ScrollToCaret();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbAddApiKey.Text.Length == 64)
            {
                bnAddApiKey.Enabled = true;
            }
            else
            {
                bnAddApiKey.Enabled = false;
            }
        }

        private void bnAddApiKey_Click(object sender, EventArgs e)
        {
            lbApiKeys.Items.Add(tbAddApiKey.Text);
            tbAddApiKey.Text = "";
            lblProjectedMin.Text = (lbApiKeys.Items.Count * 4).ToString();
            lblProjectedHr.Text = (lbApiKeys.Items.Count * 4 * 60).ToString();
            lblProjectedDay.Text = (lbApiKeys.Items.Count * 4 * 60 * 24).ToString();
            lblInterval.Text = (60.0 / Convert.ToDouble(lblProjectedMin.Text)).ToString();
            timer1.Interval = (int)(Convert.ToDouble(lblInterval.Text) * 1000.0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbApiKeys_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            lbApiKeys.Items.Clear();
            lblProjectedMin.Text = "0";
            lblProjectedHr.Text = "0";
            lblProjectedDay.Text = "0";
            lblInterval.Text = "NA";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            for (int x = lbApiKeys.SelectedIndices.Count - 1; x >= 0; x--)
            {
                int ind = lbApiKeys.SelectedIndices[x];
                lbApiKeys.Items.RemoveAt(ind);
                lblProjectedMin.Text = (lbApiKeys.Items.Count * 4).ToString();
                lblProjectedHr.Text = (lbApiKeys.Items.Count * 4 * 60).ToString();
                lblProjectedDay.Text = (lbApiKeys.Items.Count * 4 * 60 * 24).ToString();
                if (lblProjectedMin.Text != "0")
                {
                    lblInterval.Text = (60.0 / Convert.ToDouble(lblProjectedMin.Text)).ToString();
                }
                else
                {
                    lblInterval.Text = "NA";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string line;

            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.StreamReader fStream = new System.IO.StreamReader(openFileDialog1.FileName);
                    using (fStream)
                    {
                        while ((line = fStream.ReadLine()) != null)
                        {
                            if (line.Length == 64)
                            {
                                lbApiKeys.Items.Add(line);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk, original error: " + ex.Message);
                }

                lblProjectedMin.Text = (lbApiKeys.Items.Count * 4).ToString();
                lblProjectedHr.Text = (lbApiKeys.Items.Count * 4 * 60).ToString();
                lblProjectedDay.Text = (lbApiKeys.Items.Count * 4 * 60 * 24).ToString();
                if (lblProjectedMin.Text != "0")
                {
                    lblInterval.Text = (60.0 / Convert.ToDouble(lblProjectedMin.Text)).ToString();
                    timer1.Interval = (int)(Convert.ToDouble(lblInterval.Text) * 1000.0);
                }
                else
                {
                    lblInterval.Text = "NA";
                }
            }
        }

        private void aPIKeysFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
        }

        private void aPIKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem5.PerformClick();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void setDetectionThresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hashfileGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form hfCreator = new Hashfile_Creator();
            hfCreator.Show();
        }

        private void mnuHashes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            string line;

            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.StreamReader fStream = new System.IO.StreamReader(openFileDialog1.FileName);
                    using (fStream)
                    {
                        while ((line = fStream.ReadLine()) != null)
                        {
                            lbHashes.Items.Add(line);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk, original error: " + ex.Message);
                }
            }
        }

        private void mnuHashListbox_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            for (int x = lbHashes.SelectedIndices.Count - 1; x >= 0; x--)
            {
                int ind = lbHashes.SelectedIndices[x];
                lbHashes.Items.RemoveAt(ind);
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            lbHashes.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbHash.Text = lbHashes.Items[hashIndex].ToString().Split('|')[0];
            bnSubmit.PerformClick();
            if (hashIndex+1 >= lbHashes.Items.Count)
            {
                hashIndex = 0;
            }
            else
            {
                hashIndex++;
            }
        }
    }
}
