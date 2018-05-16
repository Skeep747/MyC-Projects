using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryMemory;

namespace MemoryCartds
{
    public partial class MainForm : Form, IPlayable
    {
        LogicMemoryCards logic;

        public MainForm()
        {
            InitializeComponent();
            logic = new LogicMemoryCards(this);
            logic.CreateNewGame();
        }

        private void menu_new_game_Click(object sender, EventArgs e) => logic.CreateNewGame();

        private void menu_exit_Click(object sender, EventArgs e) => this.Close();

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int nr = int.Parse(((PictureBox)sender).Tag.ToString());
            logic.ClickPicture(nr);
        }

        public void ShowWin() => MessageBox.Show("You win!", "Congratulation");

        private void LoadPicture(int picture, int image) => GetPictureBox(picture).Image = GetImage(image);

        private PictureBox GetPictureBox(int picture)
        {
            switch (picture)
            {
                case 0: return pictureBox0;
                case 1: return pictureBox1;
                case 2: return pictureBox2;
                case 3: return pictureBox3;
                case 4: return pictureBox4;
                case 5: return pictureBox5;
                case 6: return pictureBox6;
                case 7: return pictureBox7;
                case 8: return pictureBox8;
                case 9: return pictureBox9;
                case 10: return pictureBox10;
                case 11: return pictureBox11;
                case 12: return pictureBox12;
                case 13: return pictureBox13;
                case 14: return pictureBox14;
                case 15: return pictureBox15;
                default: return null;
            }
        }

        private Image GetImage(int image)
        {
            switch(image)
            {
                case 0: return Properties.Resources._0;
                case 1: return Properties.Resources._1;
                case 2: return Properties.Resources._2;
                case 3: return Properties.Resources._3;
                case 4: return Properties.Resources._4;
                case 5: return Properties.Resources._5;
                case 6: return Properties.Resources._6;
                case 7: return Properties.Resources._7;
                case 8: return Properties.Resources._8;
                default: return null;
            }
        }

        public void ShowCard(int nr, int card)
        {
            LoadPicture(nr, card);
            GetPictureBox(nr).Cursor = Cursors.Arrow;
        }

        public void HideCard(int picture)
        {
            LoadPicture(picture, 0);
            GetPictureBox(picture).Cursor = Cursors.Hand;
        }
    }
}
