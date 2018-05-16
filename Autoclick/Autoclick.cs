using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Autoclick
{
    public partial class f1 : Form
    {
        int clicks = 0;

        public f1()
        {
            InitializeComponent();
        }

        private void track_count_Scroll(object sender, EventArgs e)
        {
            label_show_count.Text = track_count.Value.ToString() + " click's";
        }

        private void track_time_Scroll(object sender, EventArgs e)
        {
            label_show_time.Text = track_time.Value.ToString() + " ms";
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            StartClicker();
        }

        private void StartClicker()
        {
            clicks = track_count.Value;
            b_start.Enabled = false;
            timer.Interval = track_time.Value;
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            MakeClick();
        }

        private void MakeClick()
        {
            clicks--;
            DoMouseClick();
            if (clicks == 0)
                StopClicks();
        }

        private void StopClicks()
        {
            timer.Enabled = false;
            b_start.Enabled = true;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public void DoMouseClick()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
    }
}
