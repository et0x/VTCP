using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
        int iDuration = 0;
        int totalSubmitted = 0;
        bool bRunning = false;
        DateTime lastSubmission = DateTime.MinValue;

        public Form1()
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();

        }


        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Environment.Exit(0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lbApiKeys.ContextMenuStrip = mnulbApiKey;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (tbHash.Text.Trim() != "")
            {

                handler.APIKey = lbApiKeys.Items[apiKeyIndex].ToString();
                string json = handler.CheckHash(tbHash.Text);

                VirusTotalResults res = JsonConvert.DeserializeObject<VirusTotalResults>(json);

                try
                {
                    if (!res.md5.Equals(null))
                    {
                        if (res.positives >= detectionThreshold)
                        {

                            RichTextBox rtbConsole = (RichTextBox)tabConsole.Controls["rtbResults"];

                            rtb.printFailure("Detections for '" + res.md5 + "': " + res.positives + " / " + res.total, rtbConsole);


                            dgvDetections.Rows.Add(res.positives, System.IO.Path.GetDirectoryName(lbHashes.Items[hashIndex].ToString().Split('|')[1]), System.IO.Path.GetFileName(lbHashes.Items[hashIndex].ToString().Split('|')[1]), res.md5);

                            if (cbVerbose.Checked)
                            {

                                rtb.printStatus("  APIKey: " + handler.APIKey, rtbConsole);
                                rtb.printStatus("  File:   " + System.IO.Path.GetFileName(lbHashes.Items[hashIndex].ToString().Split('|')[1]), rtbConsole);

                            }

                        }
                        else
                        {

                            RichTextBox rtbConsole = (RichTextBox)tabConsole.Controls["rtbResults"];
                            rtb.printSuccess("Detections for '" + res.md5 + "': " + res.positives + " / " + res.total, rtbConsole);

                            if (cbVerbose.Checked)
                            {

                                rtb.printStatus("  APIKey: " + handler.APIKey, rtbConsole);
                                rtb.printStatus("  File:   " + System.IO.Path.GetFileName(lbHashes.Items[hashIndex].ToString().Split('|')[1]), rtbConsole);

                            }

                        }
                    }
                }
                catch (NullReferenceException)
                {
                    rtb.printWarning("Unique file submitted (never submitted before)", rtbResults);
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
            if (lbApiKeys.Items.Count > 0 && lbHashes.Items.Count > 0)
            {
                startToolStripMenuItem.Enabled = true;
            }

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

            startToolStripMenuItem.Enabled = false;
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

            if (lbApiKeys.Items.Count > 0 && lbHashes.Items.Count > 0)
            {
                startToolStripMenuItem.Enabled = true;
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

            if (lbApiKeys.Items.Count > 0 && lbHashes.Items.Count > 0)
            {
                startToolStripMenuItem.Enabled = true;
                
            }

            if (lbHashes.Items.Count > 0)
            {
                lblTotalHashes.Text = lbHashes.Items.Count.ToString();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, System.EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            for (int x = lbHashes.SelectedIndices.Count - 1; x >= 0; x--)
            {
                int ind = lbHashes.SelectedIndices[x];
                lbHashes.Items.RemoveAt(ind);
            }
            if (lbApiKeys.Items.Count > 0 && lbHashes.Items.Count > 0)
            {
                startToolStripMenuItem.Enabled = true;
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

            lbHashes.Items.Clear();
            startToolStripMenuItem.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbHash.Text = lbHashes.Items[hashIndex].ToString().Split('|')[0];
            bnSubmit.PerformClick();
            pbCompleted.Increment(1);
            if (hashIndex+1 >= lbHashes.Items.Count)
            {
                hashIndex = 0;
                startToolStripMenuItem.PerformClick();
            }
            else
            {
                hashIndex++;
                if (lastSubmission != DateTime.MinValue)
                {
                    var diff = (DateTime.Now - lastSubmission).TotalSeconds;
                    lbSubmitTimes.Items.Add(diff.ToString());
                }
                lastSubmission = DateTime.Now;
            }
            lblCurrentHash.Text = hashIndex.ToString();
            if (lbSubmitTimes.Items.Count > 0)
            {
                lblAvgTime.Text = string.Format("{0:0.00}", average_ListItems(lbSubmitTimes));
                int s = (int)((lbHashes.Items.Count - hashIndex) * Convert.ToDouble(lblAvgTime.Text));
                TimeSpan t = TimeSpan.FromSeconds(s);
                lblTimeRemaining.Text = string.Format(
                    "{0:D2}h:{1:D2}m:{2:D2}s",t.Hours,t.Minutes,t.Seconds
                    );
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
        // hashes and api keys loaded? (both are needed)
            if (lbHashes.Items.Count > 0 && lbApiKeys.Items.Count > 0)
            {

            // submitter already running?
                if (runToolStripMenuItem.Checked)
                {   
                // yes, stop it!:
                    // menu items:
                    startToolStripMenuItem.Checked = false;
                    runToolStripMenuItem.Checked = false;
                    pauseToolStripMenuItem.Checked = false;
                    pauseToolStripMenuItem.Enabled = false;

                    // status bar text
                    sslStatus.ForeColor = Color.Red;
                    sslStatus.Text = "Disabled";
                    tmrDuration.Enabled = false;
                    iDuration = 0;
                    sslTimeRunning.Text = "00:00:00";

                    // stop executing submissions:
                    timer1.Enabled      = false;
                    hashIndex           = 0;
                    apiKeyIndex         = 0;
                    pbCompleted.Value   = 0;
                    lbSubmitTimes.Items.Clear();
                    lastSubmission = DateTime.MinValue;
                    lblAvgTime.Text = "NA";
                    lblTimeRemaining.Text = "NA";

                    // allow modifications to api keys / hashes:
                    toolStripMenuItem4.Enabled = true;  // api keys / remove
                    toolStripMenuItem5.Enabled = true;  // api keys / clear
                    toolStripMenuItem7.Enabled = true;  // hashes / remove
                    toolStripMenuItem8.Enabled = true;  // hashes / clear

                    // re-enable tabs
                    bRunning = false;

                }
                else
                {
                // no, start it!:
                    // menu items:
                    runToolStripMenuItem.Checked = true;
                    startToolStripMenuItem.Checked = true;
                    pauseToolStripMenuItem.Enabled = true;

                    // start executing submissions:
                    timer1.Enabled = true;

                    // status bar text:
                    sslStatus.ForeColor = Color.Green;
                    sslStatus.Text = "Running";
                    tmrDuration.Enabled = true;

                    // disallow modifications to api keys / hashes:
                    toolStripMenuItem4.Enabled = false;  // api keys / remove
                    toolStripMenuItem5.Enabled = false;  // api keys / clear
                    toolStripMenuItem7.Enabled = false;  // hashes / remove
                    toolStripMenuItem8.Enabled = false;  // hashes / clear

                    // disable tabs
                    tcOptions.SelectedTab = tabConsole;
                    bRunning = true;

                    // progress bar
                    pbCompleted.Maximum = lbHashes.Items.Count;

                }
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // already paused?
            if (pauseToolStripMenuItem.Checked)
            {
            // yes, unpause it!:
                // menu items:
                pauseToolStripMenuItem.Checked = false;
                startToolStripMenuItem.Enabled = true;

                // resume submissions
                timer1.Enabled = true;

                // status bar text:
                sslStatus.ForeColor = Color.Green;
                sslStatus.Text = "Running";
                tmrDuration.Enabled = true;

                // disable tabs
                tcOptions.SelectedTab = tabConsole;
                bRunning = true;

            }
            else
            {
            // no, pause it!:
                // menu items:
                pauseToolStripMenuItem.Checked = true;
                startToolStripMenuItem.Enabled = true;

                // pause submissions
                timer1.Enabled = false;

                // status bar text:
                sslStatus.ForeColor = Color.Blue;
                sslStatus.Text = "Paused";
                tmrDuration.Enabled = false;

                // re-enable tabs
                bRunning = false;

                // misc
                lastSubmission = DateTime.MinValue;
            }
        }

        private void lbApiKeys_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void setDetectionThresholdToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            int x = 0;

            while (!(x > 0 && x < 60))
            {
                try
                {

                    x = Convert.ToInt16(Interaction.InputBox("Enter new detection threshold for marking malicious items (1 - 60)", "Detection Threshold", "10"));

                }
                catch (Exception ex)
                {

                    // pass

                }

            }

            detectionThreshold = x;
            setDetectionThresholdToolStripMenuItem.Text = "Detection Threshold: " + detectionThreshold.ToString();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hashFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        // load list of hashes
            toolStripMenuItem6.PerformClick();

        }

        private void hashesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        // clear list of hashes
            toolStripMenuItem8.PerformClick();
        }

        private void bnClearDetections_Click(object sender, EventArgs e)
        {
            dgvDetections.Rows.Clear();
        }

        private void mnuDgvCopy_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mnuitemDvgCopy_Click(object sender, EventArgs e)
        {
            if (dgvDetections.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                Clipboard.SetDataObject(
                        dgvDetections.GetClipboardContent()
                    );

            }
        }

        private void tmrDuration_Tick(object sender, EventArgs e)
        {
            iDuration++;
            sslTimeRunning.Text = string.Format("{0:00}:{1:00}:{2:00}", iDuration / 3600, (iDuration / 60) % 60, iDuration % 60);
        }

        private void tabControl_Click(object sender, TabControlCancelEventArgs e)
        {
            if (bRunning)
            {

                int consoleTab = 1;
                int selectedTab = tcOptions.SelectedIndex;

                if (selectedTab != consoleTab)
                {
                    tcOptions.SelectedIndex = 1;
                }
            }
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            MessageBox.Show("selecting event");
        }

        private void tabControl_Deselecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void tabControl_Deselecting_1(object sender, TabControlCancelEventArgs e)
        {

        }

        private double average_ListItems(ListBox lb)
        {
            List<double> dList = new List<double>();
            foreach (string item in lb.Items)
            {
                dList.Add(Convert.ToDouble(item));
            }
            return dList.Average();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutBox = new aboutbox();
            aboutBox.Show();
        }

        private void rtbResults_MouseUp(object sender, MouseEventArgs e)
        {
            rtbResults.SelectionStart = rtbResults.Text.Length;
        }

        private void rtbResults_MouseDown(object sender, MouseEventArgs e)
        {
            rtbResults.SelectionStart = rtbResults.Text.Length;
        }
    }
}
