using System.Drawing;
using System.Windows.Forms;

namespace Labirint_2D
{
    public partial class level1 : Form
    {
        int i;

        public level1()
        {
            InitializeComponent();
        }

        private void level1_Shown(object sender, System.EventArgs e)
        {
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            Start_game();
        }

        private void labelFin_MouseEnter(object sender, System.EventArgs e)
        {
            if (i == 0)
                Finish_game();
        }

        private void label1_MouseEnter(object sender, System.EventArgs e)
        {
            Sound.play_exit();
            Restart_game();
        }

        private void label11_MouseEnter(object sender, System.EventArgs e)
        {
            Sound.play_check();
            ((Label)sender).Visible = false;
            i--;
        }

        private void Start_game()
        {
            i = 8;
            labelKey1.Visible = true;
            labelKey2.Visible = true;
            labelKey3.Visible = true;
            labelKey4.Visible = true;
            labelKey5.Visible = true;
            labelKey6.Visible = true;
            labelKey7.Visible = true;
            labelKey8.Visible = true;
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
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
    }
}
