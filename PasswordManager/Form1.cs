using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabelSite1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start((string)linkLabelSite1.Tag);
        }

        private void textBoxPassword1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxPassword1.Text);
        }
    }
}
