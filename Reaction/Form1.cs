using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Reaction
{
    public partial class Form1 : Form
    {
        int totalClicks = 10;
        int clickNr = -1;
        int reactionTime = 0;
        int myCardNr = 0;
        int waiting = 0;
        int waitingMin = 1;
        int waitingMax = 3;

        Stopwatch watch = new Stopwatch();
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            progressBar.Maximum = totalClicks;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            clickNr = 0;
            reactionTime = 0;
            buttonStart.Visible = false;
            ShowCard(0);
            NextClick();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (clickNr < 0)
            {
                return;
            }

            if (waiting > 0)
            {
                waiting--;
                if (waiting == 0)
                {
                    ShowCard(rand.Next(1, 4));
                    watch.Restart();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            watch.Stop();
            reactionTime += (int)watch.ElapsedMilliseconds;
            progressBar.Value = clickNr;
            if (clickNr >= totalClicks)
            {
                ShowResults();
            }
            else
            {
                NextClick();
            }
        }

        void ShowCard(int nr)
        {
            pictureBox1.Visible = nr == 1;
            pictureBox2.Visible = nr == 2;
            pictureBox3.Visible = nr == 3;
        }

        private void NextClick()
        {
            ShowCard(0);
            clickNr++;
            waiting = rand.Next(waitingMin * 1000 / timer.Interval, waitingMax * 1000 / timer.Interval + 1);
        }

        private void ShowResults()
        {
            double sec = reactionTime / 1000.0 / totalClicks;
            MessageBox.Show("Reaction time: " + sec.ToString("0.000") + " seconds");
            buttonStart.Visible = true;
            clickNr = -1;
        }
    }
}
