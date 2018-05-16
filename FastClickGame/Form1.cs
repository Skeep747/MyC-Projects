using System;
using System.Windows.Forms;

namespace FastClickGame
{
    public partial class Form1 : Form
    {
        long time_start;
        long time_end;
        int max_counter = 10, counter;
        string mode = "stop";

        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void PlayGame()
        {
            if (mode == "stop") return;
            if (counter == max_counter) time_start = DateTime.Now.Ticks;
            if (counter > 0) counter--;
            lb1.Text = counter.ToString();
            if (counter == 0) StopGame();
        }

        private void StopGame()
        {
            mode = "stop";
            time_end = DateTime.Now.Ticks;
            double seconds = TimeSpan.FromTicks(time_end - time_start).TotalSeconds;
            double click_per_seconds = max_counter / seconds;
            lb2.Text = click_per_seconds.ToString("#.#") + " clicks per second";
            bt1.Enabled = true;
        }

        private void lb1_MouseDown(object sender, MouseEventArgs e)
        {
            PlayGame();
        }

        private void StartGame()
        {
           if (mode == "play") return;
            mode = "play";
            counter = max_counter;
            lb1.Text = counter.ToString();
            lb2.Text = "";
            bt1.Enabled = false;
        }
    }
}
