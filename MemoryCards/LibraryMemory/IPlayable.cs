namespace LibraryMemory
{
    public interface IPlayable
    {
        void HideCard(int nr);
        void ShowCard(int nr, int card);
        void ShowWin();
    }
}