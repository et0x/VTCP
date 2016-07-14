using System.Drawing;
using System.Windows.Forms;

namespace VTCP
{
    public class RtbPrinter
    {
        private readonly Color _failureColor = Color.DarkRed;
        private readonly Color _regularColor = Color.FromArgb(0xEEEEEC);

        private readonly Color _statusColor = Color.FromArgb(0x555753);
        private readonly Color _successColor = Color.DarkGreen;
        private readonly Color _warningColor = Color.Orange;

        public void PrintStatus(string txt, RichTextBox rtb)
        {
            rtb.SelectionColor = _statusColor;
            rtb.SelectedText = "[*] " + txt + "\r\n";
        }

        public void PrintSuccess(string txt, RichTextBox rtb)
        {
            rtb.SelectionColor = _successColor;
            rtb.SelectedText = "[+] " + txt + "\r\n";
        }

        public void PrintFailure(string txt, RichTextBox rtb)
        {
            rtb.SelectionColor = _failureColor;
            rtb.SelectedText = "[-] " + txt + "\r\n";
        }

        public void PrintWarning(string txt, RichTextBox rtb)
        {
            rtb.SelectionColor = _warningColor;
            rtb.SelectedText = "[!] " + txt + "\r\n";
        }

        public void PrintRegular(string txt, RichTextBox rtb)
        {
            rtb.SelectionColor = _regularColor;
            rtb.SelectedText = txt + "\r\n";
        }
    }
}