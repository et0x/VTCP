using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace VTCP
{
    public class RTBPrinter
    {

        Color statusColor = Color.FromArgb(0x555753);
        Color successColor = Color.DarkGreen;
        Color failureColor = Color.DarkRed;
        Color warningColor = Color.Orange;
        Color regularColor = Color.FromArgb(0xEEEEEC);

        public void printStatus(string txt, RichTextBox rtb)
        {
            rtb.SelectionColor = statusColor;
            rtb.SelectedText = "[*] " + txt + "\r\n";
        }

        public void printSuccess(string txt, RichTextBox rtb)
        {
            rtb.SelectionColor = successColor;
            rtb.SelectedText = "[+] " + txt + "\r\n";
        }

        public void printFailure(string txt, RichTextBox rtb)
        {
            rtb.SelectionColor = failureColor;
            rtb.SelectedText = "[-] " + txt + "\r\n";
        }

        public void printWarning(string txt, RichTextBox rtb)
        {
            rtb.SelectionColor = warningColor;
            rtb.SelectedText = "[!] " + txt + "\r\n";
        }

        public void printRegular(string txt, RichTextBox rtb)
        {
            rtb.SelectionColor = regularColor;
            rtb.SelectedText = txt + "\r\n";
        }
    }
}
