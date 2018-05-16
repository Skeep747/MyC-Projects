using System;
using System.Drawing;
using System.Windows.Forms;

namespace EnglishCards
{
    public partial class Form1 : Form
    {
        Dictionary dictionary;
        int curr = 0;

        public Form1()
        {
            InitializeComponent();
            dictionary = new Dictionary();
            ShowCard();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (curr <= 0) return;
            curr--;
            ShowCard();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (curr >= dictionary.Total() - 1) return;
            curr++;
            ShowCard();
        }

        private void labelRussian_Click(object sender, EventArgs e)
        {
            PlayMp3(dictionary.AudioRus(curr));
        }

        private void labelEnglish_Click(object sender, EventArgs e)
        {
            PlayMp3(dictionary.AudioEng(curr));
        }

        private void labelVideo_Click(object sender, EventArgs e)
        {
            PlayMp4(dictionary.Video(curr));
        }

        void ShowCard()
        {
            pictureCard.Image = Image.FromFile(dictionary.Image(curr));
            labelEnglish.Text = dictionary.English(curr);
            labelRussian.Text = dictionary.Russian(curr);
            labelVideo.Visible = dictionary.Video(curr) != "";
        }

        void PlayMp3(string filename)
        {
            if (filename == "") return;
            player.Visible = false;
            player.URL = filename;
        }

        void PlayMp4(string filename)
        {
            if (filename == "") return;
            player.Visible = true;
            player.uiMode = "none";
            player.URL = filename;
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
                player.Visible = false;
        }
    }
}
