using System.Windows.Forms;

namespace Scope
{
    public partial class Form1 : Form
    {
        Box [,] box;
        int w, h;

        public Form1()
        {
            InitializeComponent();
            Init();
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            Box.ChoiseFigure();
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    box[i, j].DrowFigure();
                }
            }
        }

        private void Init()
        {
            w = panel.Width / panel1.Width;
            h = panel.Height / panel1.Height;
            Box.SetSize(panel1.Width, panel1.Height);
            int sx, sy;

            box = new Box[w, h];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Panel cell = new Panel();
                    cell.Parent = panel;
                    cell.Location = new System.Drawing.Point(i * panel1.Width, j * panel1.Height);
                    cell.Size = new System.Drawing.Size(panel1.Width, panel1.Height);
                    sx = (i % 2 == 1) ? -1 : 1;
                    sy = (j % 2 == 1) ? -1 : 1;
                    box[i, j] = new Box(cell, sx, sy);
                }
            }
        }
    }
}
