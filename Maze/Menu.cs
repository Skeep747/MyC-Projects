using System;
using System.Windows.Forms;

namespace Labirint_2D
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start_level1();
        }

        private void Start_level1()
        {
            Sound.play_start();
            level1 level1 = new level1();
            DialogResult dr = level1.ShowDialog();
            if (dr == DialogResult.OK) Start_level2();
        }

        private void Start_level2()
        {
            Sound.play_start();
            level2 level2 = new level2();
            DialogResult dr = level2.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DialogResult dr2 = MessageBox.Show("All levels are passed! \nStart from the beginning? ", " Victory!", MessageBoxButtons.YesNo);
                if (dr2 == DialogResult.Yes) Start_level1();
                else this.Close();
            }
        }

        private void checkSound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSound.Checked)
            {
                checkSound.Text = "Sound on";
                Sound.soud_on();
            }
            else
            {
                checkSound.Text = "Sound off";
                Sound.sound_off();
            }
            Sound.play_check();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
