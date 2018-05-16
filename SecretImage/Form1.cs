using System;
using System.Windows.Forms;

namespace Secret_Image
{
    public partial class Form1 : Form
    {
        int secret_nr = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (secret_nr >= 2)
            {
                pictureBox1.Image = Properties.Resources._5;
                secret_nr = 0;
            }
            else
            {
                pictureBox1.Image = Properties.Resources._1;
                secret_nr = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (secret_nr >= 2)
            {
                pictureBox1.Image = Properties.Resources._5;
                secret_nr = 0;
            }
            else
            {
                pictureBox1.Image = Properties.Resources._2;
                secret_nr = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (secret_nr >= 2)
            {
                pictureBox1.Image = Properties.Resources._5;
                secret_nr = 0;
            }
            else
            {
                pictureBox1.Image = Properties.Resources._3;
                secret_nr = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (secret_nr >= 2)
            {
                pictureBox1.Image = Properties.Resources._5;
                secret_nr = 0;
            }
            else
            {
                pictureBox1.Image = Properties.Resources._4;
                secret_nr = 0;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) secret_nr = 1;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < 15 && e.Y > 550 && secret_nr == 1) secret_nr = 2;
        }
    }
}
