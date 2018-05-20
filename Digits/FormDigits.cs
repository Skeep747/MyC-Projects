using System;
using System.Windows.Forms;

namespace Digits
{
    public partial class FormDigits : Form
    {
        int buttons = 9;
        int currentButton;

        Random rand = new Random();

        public FormDigits()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My CSharp project\nSkeep747@gmail.com", "About");
        }

        private void menuNewGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nr = int.Parse(((Button)sender).Text);
            if (nr == currentButton)
            {
                ((Button)sender).Visible = false;
                currentButton++;
                if (currentButton == buttons + 1)
                {
                    DialogResult dr = MessageBox.Show("You win!\nRun new game?", "Cungratulations", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.No)
                    {
                        Close();
                    }
                    else
                    {
                        StartGame();
                    }
                }
            }
        }

        private void StartGame()
        {
            currentButton = 1;
            for (int i = 1; i <= buttons; i++)
            {
                Button(i).Text = i.ToString();
            }
            for (int i = 1; i <= 50; i++)
            {
                SwapButtons();
            }
            for (int i = 1; i <= buttons; i++)
            {
                Button(i).Visible = true;
            }
        }

        private Button Button(int nr)
        {
            switch (nr)
            {
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                default: return null;
            }
        }

        private void SwapButtons()
        {
            int a = rand.Next(1, buttons + 1);
            int b = rand.Next(1, buttons + 1);
            if (a == b) return;
            string text = Button(a).Text;
            Button(a).Text = Button(b).Text;
            Button(b).Text = text;
        }
    }
}
