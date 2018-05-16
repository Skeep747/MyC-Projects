using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void startGameMenu_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame();
            game.ShowDialog();
        }
    }
}
