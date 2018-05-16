using System;
using System.Windows.Forms;

namespace Verbal_counting
{
    public partial class Form1 : Form
    {
        int count, countMax = 10;
        int min = 1, max = 10;
        Random rand = new Random();
        string answer;
        string mode;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Start(((Button)sender).Tag.ToString());
        }

        private void textAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textAnswer.Text == answer)
                {
                    progress.Value = count;
                    if (count == countMax)
                        GameWin();
                    else
                    {
                        textAnswer.Text = "";
                        Think();
                    }
                }
                else
                    Gameover();
            }
        }
        private void Start(string _mode)
        {
            mode = _mode;
            textAnswer.Text = "";
            buttonAdd.Visible = false;
            buttonSub.Visible = false;
            buttonMult.Visible = false;
            buttonDev.Visible = false;
            textBoxLevel.Visible = false;
            progress.Visible = true;
            progress.Minimum = 0;
            progress.Maximum = countMax;
            progress.Value = 0;
            count = 0;
            try
            {
                max = Convert.ToInt32(textBoxLevel.Text);
            }
            catch
            {
                max = 10;
                textBoxLevel.Text = max.ToString();
            }
            Think();
        }

        private void Think()
        {
            int a, b;
            a = rand.Next(min, max + 1);
            b = rand.Next(min, max + 1);
            if (mode == "add")
            {
                labelThink.Text = a.ToString() + " + " + b.ToString() + " = ";
                answer = (a + b).ToString();
            }
            if (mode == "sub")
            {
                if (a < b)
                {
                    int x = a;
                    a = b;
                    b = x;
                }
                labelThink.Text = a.ToString() + " – " + b.ToString() + " = ";
                answer = (a - b).ToString();
            }
            if (mode == "mult")
            {
                labelThink.Text = a.ToString() + " * " + b.ToString() + " = ";
                answer = (a * b).ToString();
            }
            if (mode == "dev")
            {
                labelThink.Text = (a*b).ToString() + " / " + b.ToString() + " = ";
                answer = a.ToString();
            }
            count++;
        }

        private void Gameover()
        {
            textAnswer.Text = answer;
            progress.Visible = false;
            buttonAdd.Visible = true;
            buttonSub.Visible = true;
            buttonMult.Visible = true;
            buttonDev.Visible = true;
            textBoxLevel.Visible = true;
        }

        private void GameWin()
        {
            MessageBox.Show("You win!", "Congratulations!");
            progress.Visible = false;
            buttonAdd.Visible = true;
            buttonSub.Visible = true;
            buttonMult.Visible = true;
            buttonDev.Visible = true;
            textBoxLevel.Visible = true;
        }
    }
}
