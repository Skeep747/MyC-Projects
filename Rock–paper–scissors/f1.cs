using System;
using System.Windows.Forms;

namespace Rock_paper_scissors
{
    public partial class f1 : Form
    {
        string userFigure = "";
        string computerFigure = "";
        static Random rand = new Random();
        int scoreVictories = 0;
        int scoreDefeats = 0;
        int scoreDraws = 0;
        string mode = "show";
        string figure = "";

        public f1()
        {
            InitializeComponent();
            ShowScore();
            SetComputerSpeed();
        }

        void panelScissor_MouseEnter(object sender, EventArgs e) => ShowUserFigure("Scissors");

        void panelPaper_MouseEnter(object sender, EventArgs e) => ShowUserFigure("Paper");

        void panelRock_MouseEnter(object sender, EventArgs e) => ShowUserFigure("Rock");

        void timer_Tick(object sender, EventArgs e)
        {
            if (mode == "game")
                ComputerRandomFigure();
        }

        void trackBar1_Scroll(object sender, EventArgs e) => SetComputerSpeed();

        void userPictureBoxScissors_MouseClick(object sender, MouseEventArgs e) => ChechResult();

        void userPictureBoxPaper_MouseClick(object sender, MouseEventArgs e) => ChechResult();

        void userPictureBoxRock_MouseClick(object sender, MouseEventArgs e) => ChechResult();

        void ShowUserFigure(string figure)
        {
            HideComputerFigure();
            StartGame();
            userPictureBoxRock.Visible = figure == "Rock";
            userPictureBoxPaper.Visible = figure == "Paper";
            userPictureBoxScissors.Visible = figure == "Scissors";
            userFigure = figure;
        }

        void HideComputerFigure()
        {
            computerPictureBoxRock.Visible = false;
            computerPictureBoxPaper.Visible = false;
            computerPictureBoxScissors.Visible = false;
        }

        void StartGame()
        {
            if (mode != "game")
            {
                lUser.Text = "Choose you figure!";
                mode = "game";
            }
        }

        void ShowComputerFigure(string figure)
        {
            computerPictureBoxRock.Visible = figure == "Rock";
            computerPictureBoxPaper.Visible = figure == "Paper";
            computerPictureBoxScissors.Visible = figure == "Scissors";
            computerFigure = figure;
        }

        void ComputerRandomFigure()
        {
            int f = rand.Next(1, 4);
            if (f == 3) figure = "Rock";
            if (f == 2) figure = "Paper";
            if (f == 1) figure = "Scissors";
        }

        void ShowScore()
        {
            lScore.Text =
                "Victories: " + scoreVictories +
                " Defeats: " + scoreDefeats +
                " Draws: " + scoreDraws;
        }

        void ChechResult()
        {
            ShowComputerFigure(figure);
            mode = "show";
            int victories = 0;
            int defeats = 0;
            int draws = 0;
            if (userFigure == computerFigure)
                draws = 1;
            else
            {
                if (userFigure == "Rock")
                    if (computerFigure == "Scissors")
                        victories = 1;
                    else defeats = 1;
                if (userFigure == "Scissors")
                    if (computerFigure == "Paper")
                        victories = 1;
                    else defeats = 1;
                if (userFigure == "Paper")
                    if (computerFigure == "Rock")
                        victories = 1;
                    else defeats = 1;
            }
            scoreVictories += victories;
            scoreDefeats += defeats;
            scoreDraws += draws;
            if (victories > 0)
                lUser.Text = "Victori :)";
            if (defeats > 0)
                lUser.Text = "Defeat :(";
            if (draws > 0)
                lUser.Text = "Draw :|";
            ShowScore();
        }

        void SetComputerSpeed()
        {
            if (trackBarSpeed.Value == 5) timer.Interval = 40;
            if (trackBarSpeed.Value == 4) timer.Interval = 70;
            if (trackBarSpeed.Value == 3) timer.Interval = 100;
            if (trackBarSpeed.Value == 2) timer.Interval = 200;
            if (trackBarSpeed.Value == 1) timer.Interval = 300;
        }
    }
}
