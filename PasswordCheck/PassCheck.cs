using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordCheck
{
    public partial class PassCheck : Form
    {
        public PassCheck()
        {
            InitializeComponent();
        }

        string hpass = "";
        string pass = "";

        private void bt1_Click(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(textBox1.Text));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            hpass = sBuilder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(textBox2.Text));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            pass = sBuilder.ToString();
            Check_pass();
        }

        private void Check_pass()
        {
            if (pass == hpass) MessageBox.Show("Correct password!", "Correctly!");
            else MessageBox.Show("Incorrect password!", "Wrong!");
        }
    }
}
