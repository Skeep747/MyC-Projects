using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class FormGame : Form
    {
        static Random random = new Random();
        int racketX, racketY, racketShift = 8;
        int ballX, ballY, ballSX, ballSY, ballShiftX = 6, ballShiftY = 4;
        int sideLX, sideRX, sideUY;
        int totalBricks;

        private void timer_Tick(object sender, EventArgs e)
        {
            MoveBall();
        }

        int ax1, ax2;

        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Shown(object sender, EventArgs e)
        {
            InitGame();
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
            {
                case Keys.Left: RacketShift(-racketShift); break;
                case Keys.Right: RacketShift(racketShift); break;
                case Keys.Enter: timer.Enabled = true; break;
            }

        }

        void InitGame()
        {
            racketX = racket.Location.X;
            racketY = racket.Location.Y;
            sideLX = labelLeft.Location.X + labelLeft.Width;
            sideRX = labelRight.Location.X;
            sideUY = labelTop.Location.X + labelTop.Height;
            ballX = ball.Location.X;
            ballY = ball.Location.Y;
            ballSX = ballShiftX;
            ballSY = -ballShiftY;
            totalBricks = 6;
        }

        void RacketShift(int _racketShift)
        {
            ax1 = racketX + _racketShift;
            ax2 = ax1 + racket.Width;
            if (sideLX > ax1) ax1 = sideLX;
            if (sideRX < ax2) ax1 = sideRX - racket.Width;
            racketX = ax1;
            racket.Location = new Point(racketX, racketY);

        }
        
        void MoveBall()
        {
            int bx0, by0, bx1, bx2, by1, by2, rx1, rx2;
            bx1 = ballX;
            by1 = ballY;
            bx2 = ballX + ball.Width;
            by2 = ballY + ball.Width;
            if (bx1 + ballSX < sideLX)
                ballSX = ballShiftX;
            if (bx2 + ballSX > sideRX)
                ballSX = -ballShiftX;
            if (by1 + ballSY < sideUY)
                ballSY = ballShiftY;
            if (by2 + ballSY > racketY)
            {
                rx1 = racketX;
                rx2 = racketX + racket.Width;
                bx0 = (bx1 + bx2) / 2;
                by0 = (by1 + by2) / 2;
                if (rx1 <= bx0 && bx0 <= rx2)
                    ballSY = -ballShiftY + random.Next(-1, 2);
                else
                    if (rx1 <= bx2 + ball.Width && bx2 + ball.Width <= rx2)
                {
                    ballSY = -ballShiftY + random.Next(-1, 2);
                    ballSX = -ballShiftX + random.Next(-1, 2);
                }
                else
                    if (rx1 <= bx1 - ball.Width && bx1 - ball.Width <= rx2)
                {
                    ballSY = -ballShiftY + random.Next(-1, 2);
                    ballSX = ballShiftX + random.Next(-1, 2);
                }
                else
                    Lose();
            }
            ballX += ballSX;
            ballY += ballSY;
            ball.Location = new Point(ballX, ballY);
            CrossBrick(brick1);
            CrossBrick(brick2);
            CrossBrick(brick3);
            CrossBrick(brick4);
            CrossBrick(brick5);
            CrossBrick(brick6);
        }

        private void CrossBrick(Label brick)
        {
            if (!brick.Visible) return;
            int bx1 = ballX;
            int by1 = ballY;
            int bx2 = ballX + ball.Width;
            int by2 = ballY + ball.Width;
            int bx0 = (bx1 + bx2) / 2;
            int by0 = (by1 + by2) / 2;
            int rx1 = brick.Location.X;
            int rx2 = rx1 + brick.Width;
            int ry1 = brick.Location.Y;
            int ry2 = ry1 + brick.Height;
            if (rx1 <= bx0 && bx0 <= rx2 && ry1 <= by2 && by2 <= ry2)
            {
                DropBrick(brick);
                ballSY = -ballSY;
                return;
            }
            if (rx1 <= bx0 && bx0 <= rx2 && ry1 <= by1 && by1 <= ry2)
            {
                DropBrick(brick);
                ballSY = -ballSY;
                return;
            }
            if (rx1 <= bx2 && bx0 <= rx2 && ry1 <= by0 && by2 <= ry2)
            {
                DropBrick(brick);
                ballSX = -ballSX;
                return;
            }
            if (rx1 <= bx1 && bx1 <= rx2 && ry1 <= by0 && by0 <= ry2)
            {
                DropBrick(brick);
                ballSX = -ballSX;
                return;
            }
        }

        private void DropBrick(Label brick)
        {
            brick.Visible = false;
            totalBricks--;
            if (totalBricks == 0)
            {
                timer.Enabled = false;
                MessageBox.Show("You win!", "Congratulation");
                DialogResult = DialogResult.OK;
            }
        }

        private void Lose()
        {
            timer.Enabled = false;
            MessageBox.Show("You lose!", "Loss");
            DialogResult = DialogResult.Abort;
        }
    }
}
