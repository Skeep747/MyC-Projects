using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace DigitsClicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxX.Text = "";
            textBoxY.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Cursor.Position.X;
            y = Cursor.Position.Y;
            textBoxX.Text += x.ToString() + Environment.NewLine;
            textBoxY.Text += y.ToString() + Environment.NewLine;
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private void DoMouseClick(int x, int y)
        {
            Cursor.Position = new Point(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }

        private void buttonRepeat_Click(object sender, EventArgs e)
        {
            int x, y;
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < textBoxX.Lines.Length - 1; i++)
                {
                    x = int.Parse(textBoxX.Lines[i]);
                    y = int.Parse(textBoxY.Lines[i]);
                    DoMouseClick(x, y);
                }
            }
        }
    }
}
