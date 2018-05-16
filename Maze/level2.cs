using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labirint_2D
{
    public partial class level2 : Form
    {
        public level2()
        {
            InitializeComponent();
        }

        private void level2_Shown(object sender, EventArgs e)
        {
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            Start_game();
        }

        private void labelDoor_MouseEnter(object sender, EventArgs e)
        {
            Sound.play_exit();
            Restart_game();
        }

        private void labelKey_MouseEnter(object sender, EventArgs e)
        {
            Sound.play_check();
            Open_door();
        }

        private void labelFin_MouseEnter(object sender, EventArgs e)
        {
            Finish_game();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelFlash1.Visible = !labelFlash1.Visible;
            labelFlash2.Visible = !labelFlash2.Visible;
            labelFlash3.Visible = !labelFlash3.Visible;
        }

        private void Start_game()
        {
            Close_door();
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            labelFlash1.Visible = true;
            labelFlash2.Visible = false;
            labelFlash3.Visible = true;
        }

        private void Finish_game()
        {
            Sound.play_win();
            this.DialogResult = DialogResult.OK;
        }

        private void Restart_game()
        {
            DialogResult dr = MessageBox.Show("Go beyond the maze!\nTo retry?", "You lose :(", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) Start_game();
            else this.DialogResult = DialogResult.Abort;
        }

        private void Close_door()
        {
            labelKey.Visible = true;
            labelDoor.Visible = true;
        }

        private void Open_door()
        {
            labelKey.Visible = false;
            labelDoor.Visible = false;
        }
    }
}
