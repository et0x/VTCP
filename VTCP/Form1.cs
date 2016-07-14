using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace VTCP
{
    public partial class Form1 : Form
    {
        private readonly VirusTotalHandler _handler = new VirusTotalHandler();
        private readonly RtbPrinter _rtb = new RtbPrinter();
        private int _apiKeyIndex;
        public bool BRunning;
        private int _detectionThreshold = 10;
        private int _hashIndex;
        private int _iDuration;
        private int _keyRate = 4;
        private DateTime _lastSubmission = DateTime.MinValue;

        public Form1()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }


        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbRate.SelectedIndex = 0;
            lbApiKeys.ContextMenuStrip = mnulbApiKey;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PerformSubmission();
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
            lblProjectedMin.Text = (lbApiKeys.Items.Count*_keyRate).ToString();
            lblProjectedHr.Text = (lbApiKeys.Items.Count*_keyRate*60).ToString();
            lblProjectedDay.Text = (lbApiKeys.Items.Count*_keyRate*60*24).ToString();
            lblInterval.Text = (60.0/Convert.ToDouble(lblProjectedMin.Text)).ToString(CultureInfo.InvariantCulture);
            timer1.Interval = (int) (Convert.ToDouble(lblInterval.Text)*1000.0);
            if (lbApiKeys.Items.Count > 0 && lbHashes.Items.Count > 0)
            {
                startToolStripMenuItem.Enabled = true;
                cbRate.Enabled = true;
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            lbApiKeys.Items.Clear();
            lblProjectedMin.Text = @"0";
            lblProjectedHr.Text = @"0";
            lblProjectedDay.Text = @"0";
            lblInterval.Text = @"NA";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            for (var x = lbApiKeys.SelectedIndices.Count - 1; x >= 0; x--)
            {
                var ind = lbApiKeys.SelectedIndices[x];
                lbApiKeys.Items.RemoveAt(ind);
                lblProjectedMin.Text = (lbApiKeys.Items.Count*_keyRate).ToString();
                lblProjectedHr.Text = (lbApiKeys.Items.Count*_keyRate*60).ToString();
                lblProjectedDay.Text = (lbApiKeys.Items.Count*_keyRate*60*24).ToString();

                if (lblProjectedMin.Text != @"0")
                {
                    lblInterval.Text =
                        (60.0/Convert.ToDouble(lblProjectedMin.Text)).ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    lblInterval.Text = @"NA";
                }
            }

            startToolStripMenuItem.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string line;
            openFileDialog1.Filter = @"Text files (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fStream = new StreamReader(openFileDialog1.FileName);

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
                    MessageBox.Show(@"Error: Could not read file from disk, original error: " + ex.Message);
                }

                lblProjectedMin.Text = (lbApiKeys.Items.Count*_keyRate).ToString();
                lblProjectedHr.Text = (lbApiKeys.Items.Count*_keyRate*60).ToString();
                lblProjectedDay.Text = (lbApiKeys.Items.Count*_keyRate*60*24).ToString();

                if (lblProjectedMin.Text != @"0")
                {
                    lblInterval.Text =
                        (60.0/Convert.ToDouble(lblProjectedMin.Text)).ToString(CultureInfo.InvariantCulture);
                    timer1.Interval = (int) (Convert.ToDouble(lblInterval.Text)*1000.0);
                }
                else
                {
                    lblInterval.Text = @"NA";
                }
            }

            if (lbApiKeys.Items.Count > 0 && lbHashes.Items.Count > 0)
            {
                startToolStripMenuItem.Enabled = true;
                cbRate.Enabled = true;
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

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            string line;

            openFileDialog1.Filter = @"Text files (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fStream = new StreamReader(openFileDialog1.FileName);

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
                    MessageBox.Show(@"Error: Could not read file from disk, original error: " + ex.Message);
                }
            }

            if (lbApiKeys.Items.Count > 0 && lbHashes.Items.Count > 0)
            {
                startToolStripMenuItem.Enabled = true;
                cbRate.Enabled = true;
            }

            if (lbHashes.Items.Count > 0)
            {
                lblTotalHashes.Text = lbHashes.Items.Count.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            for (var x = lbHashes.SelectedIndices.Count - 1; x >= 0; x--)
            {
                var ind = lbHashes.SelectedIndices[x];
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
            tbHash.Text = lbHashes.Items[_hashIndex].ToString().Split('|')[0];
            PerformSubmission();
            pbCompleted.Increment(1);
            if (_hashIndex + 1 >= lbHashes.Items.Count)
            {
                _hashIndex = 0;
                startToolStripMenuItem.PerformClick();
            }
            else
            {
                _hashIndex++;
                if (_lastSubmission != DateTime.MinValue)
                {
                    var diff = (DateTime.Now - _lastSubmission).TotalSeconds;
                    lbSubmitTimes.Items.Add(diff.ToString(CultureInfo.InvariantCulture));
                }
                _lastSubmission = DateTime.Now;
            }
            lblCurrentHash.Text = _hashIndex.ToString();
            if (lbSubmitTimes.Items.Count > 0)
            {
                lblAvgTime.Text = string.Format("{0:0.00}", average_ListItems(lbSubmitTimes));
                var s = (int) ((lbHashes.Items.Count - _hashIndex)*Convert.ToDouble(lblAvgTime.Text));
                var t = TimeSpan.FromSeconds(s);
                lblTimeRemaining.Text = string.Format(
                    "{0:D2}h:{1:D2}m:{2:D2}s", t.Hours, t.Minutes, t.Seconds
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
                    sslStatus.Text = @"Disabled";
                    tmrDuration.Enabled = false;
                    _iDuration = 0;
                    sslTimeRunning.Text = @"00:00:00";

                    // stop executing submissions:
                    timer1.Enabled = false;
                    _hashIndex = 0;
                    _apiKeyIndex = 0;
                    pbCompleted.Value = 0;
                    lbSubmitTimes.Items.Clear();
                    _lastSubmission = DateTime.MinValue;
                    lblAvgTime.Text = @"NA";
                    lblTimeRemaining.Text = @"NA";
                    bnSubmit.Enabled = true;

                    // allow modifications to api keys / hashes:
                    toolStripMenuItem4.Enabled = true; // api keys / remove
                    toolStripMenuItem5.Enabled = true; // api keys / clear
                    toolStripMenuItem7.Enabled = true; // hashes / remove
                    toolStripMenuItem8.Enabled = true; // hashes / clear

                    // re-enable tabs
                    BRunning = false;
                    tcOptions.Enabled = true;
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
                    bnSubmit.Enabled = false;
                    lblDetections.Text = @"0";

                    // status bar text:
                    sslStatus.ForeColor = Color.Green;
                    sslStatus.Text = @"Running";
                    tmrDuration.Enabled = true;

                    // disallow modifications to api keys / hashes:
                    toolStripMenuItem4.Enabled = false; // api keys / remove
                    toolStripMenuItem5.Enabled = false; // api keys / clear
                    toolStripMenuItem7.Enabled = false; // hashes / remove
                    toolStripMenuItem8.Enabled = false; // hashes / clear

                    // disable tabs
                    tcOptions.SelectedTab = tabConsole;
                    tcOptions.Enabled = false;
                    BRunning = true;

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
                bnSubmit.Enabled = false;

                // status bar text:
                sslStatus.ForeColor = Color.Green;
                sslStatus.Text = @"Running";
                tmrDuration.Enabled = true;

                // disable tabs
                tcOptions.SelectedTab = tabConsole;
                tcOptions.Enabled = false;
                BRunning = true;
            }
            else
            {
                // no, pause it!:
                // menu items:
                pauseToolStripMenuItem.Checked = true;
                startToolStripMenuItem.Enabled = true;

                // pause submissions
                timer1.Enabled = false;
                bnSubmit.Enabled = true;

                // status bar text:
                sslStatus.ForeColor = Color.Blue;
                sslStatus.Text = @"Paused";
                tmrDuration.Enabled = false;

                // re-enable tabs
                BRunning = false;
                tcOptions.Enabled = true;

                // misc
                _lastSubmission = DateTime.MinValue;
            }
        }

        private void lbApiKeys_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void setDetectionThresholdToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var x = 0;

            while (!(x > 0 && x < 60))
            {
                try
                {
                    x =
                        Convert.ToInt16(
                            Interaction.InputBox("Enter new detection threshold for marking malicious items (1 - 60)",
                                "Detection Threshold", "10"));
                }
                catch (Exception)
                {
                    // pass
                }
            }

            _detectionThreshold = x;
            setDetectionThresholdToolStripMenuItem.Text = @"Detection Threshold: " + _detectionThreshold;
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
            _iDuration++;
            sslTimeRunning.Text = string.Format("{0:00}:{1:00}:{2:00}", _iDuration/3600, _iDuration/60%60, _iDuration%60);
        }

        private void tabControl_Deselecting_1(object sender, TabControlCancelEventArgs e)
        {
        }

        private double average_ListItems(ListBox lb)
        {
            var dList = new List<double>();
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

        private void PerformSubmission()
        {
            if (tbHash.Text.Trim() != "")
            {
                _handler.ApiKey = lbApiKeys.Items[_apiKeyIndex].ToString();
                var json = _handler.CheckHash(tbHash.Text);

                var res = JsonConvert.DeserializeObject<VirusTotalResults>(json);

                try
                {
                    if (res.positives >= _detectionThreshold)
                    {
                        var rtbConsole = (RichTextBox) tabConsole.Controls["rtbResults"];

                        _rtb.PrintFailure("Detections for '" + res.md5 + "': " + res.positives + " / " + res.total,
                            rtbConsole);
                        lblDetections.Text = (Convert.ToInt32(lblDetections.Text) + 1).ToString();

                        dgvDetections.Rows.Add(res.positives,
                            Path.GetDirectoryName(lbHashes.Items[_hashIndex].ToString().Split('|')[1]),
                            Path.GetFileName(lbHashes.Items[_hashIndex].ToString().Split('|')[1]), res.md5);

                        if (cbVerbose.Checked)
                        {
                            _rtb.PrintStatus("  APIKey: " + _handler.ApiKey, rtbConsole);
                            _rtb.PrintStatus(
                                "  File:   " + Path.GetFileName(lbHashes.Items[_hashIndex].ToString().Split('|')[1]),
                                rtbConsole);
                        }
                    }
                    else
                    {
                        var rtbConsole = (RichTextBox) tabConsole.Controls["rtbResults"];
                        _rtb.PrintSuccess("Detections for '" + res.md5 + "': " + res.positives + " / " + res.total,
                            rtbConsole);

                        if (cbVerbose.Checked)
                        {
                            _rtb.PrintStatus("  APIKey: " + _handler.ApiKey, rtbConsole);
                            _rtb.PrintStatus(
                                "  File:   " + Path.GetFileName(lbHashes.Items[_hashIndex].ToString().Split('|')[1]),
                                rtbConsole);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                    _rtb.PrintWarning("Unique file submitted (no detection report available)", rtbResults);
                    if (cbVerbose.Checked)
                    {
                        _rtb.PrintStatus("  APIKey: " + _handler.ApiKey, rtbResults);
                        _rtb.PrintStatus(
                            "  File:   " + Path.GetFileName(lbHashes.Items[_hashIndex].ToString().Split('|')[1]),
                            rtbResults);
                    }
                }
                if (_apiKeyIndex + 1 >= lbApiKeys.Items.Count)
                {
                    _apiKeyIndex = 0;
                }
                else
                {
                    _apiKeyIndex++;
                }

                rtbResults.SelectionStart = rtbResults.Text.Length;
                rtbResults.ScrollToCaret();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void cbRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            _keyRate = Convert.ToInt32(cbRate.GetItemText(cbRate.SelectedItem));
            lblProjectedMin.Text = (lbApiKeys.Items.Count*_keyRate).ToString();
            lblProjectedHr.Text = (lbApiKeys.Items.Count*_keyRate*60).ToString();
            lblProjectedDay.Text = (lbApiKeys.Items.Count*_keyRate*60*24).ToString();
            lblInterval.Text = (60.0/Convert.ToDouble(lblProjectedMin.Text)).ToString(CultureInfo.InvariantCulture);
            if (lbApiKeys.Items.Count > 0 && lbHashes.Items.Count > 0)
            {
                timer1.Interval = (int) (Convert.ToDouble(lblInterval.Text)*1000.0);
            }
        }

        private void mnulbApiKey_Opening(object sender, CancelEventArgs e)
        {
        }
    }
}