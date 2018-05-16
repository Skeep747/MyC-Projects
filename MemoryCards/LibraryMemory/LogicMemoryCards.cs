using System;

namespace LibraryMemory
{
    public class LogicMemoryCards
    {
        IPlayable play;
        static Random rand = new Random();
        int[] cards = new int[16];
        bool[] opens = new bool[16];
        int done, status, card_a, card_b;

        public LogicMemoryCards(IPlayable _play)
        {
            play = _play;
        }

        public void CreateNewGame()
        {
            for (int i = 0; i < cards.Length; i++)
                cards[i] = i % (cards.Length / 2) + 1;
            for (int i = 0; i < 100; i++)
                ShuffleCards();
            for (int i = 0; i < cards.Length; i++)
            {
                play.HideCard(i);
                opens[i] = false;
            }
            status = done = 0;
        }

        public void ClickPicture(int nr)
        {
            if (opens[nr]) return;
            switch (status)
            {
                case 0: Status0(nr); break;
                case 1: Status1(nr); break;
                case 2: Status2(nr); break;
                case 3: Status3(nr); break;
            }
        }

        private void ShuffleCards()
        {
            int a = rand.Next(0, cards.Length);
            int b = rand.Next(0, cards.Length);
            if (a == b) return;
            int x;
            x = cards[a];
            cards[a] = cards[b];
            cards[b] = x;
        }

        private void Open(int picture)
        {
            opens[picture] = true;
            play.ShowCard(picture, cards[picture]);
        }

        private void Status0(int nr)
        {
            card_a = nr;
            play.ShowCard(card_a, cards[card_a]);
            status = 1;
        }

        private void Status1(int nr)
        {
            card_b = nr;
            if (card_a == card_b)
                return;
            play.ShowCard(card_b, cards[card_b]);
            status = 2;
            if (cards[card_a] == cards[card_b])
            {
                Open(card_a);
                Open(card_b);
                done += 2;
                if (done == 16)
                    play.ShowWin();
                else status = 0;
            }
            else status = 3;
        }

        private void Status2(int nr)
        {
        }

        private void Status3(int nr)
        {
            play.HideCard(card_a);
            play.HideCard(card_b);
            Status0(nr);
        }
    }
}
