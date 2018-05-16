using System.Media;

namespace Labirint_2D
{
    public static class Sound
    {
        static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.Start);
        static SoundPlayer sound_exit = new SoundPlayer(Properties.Resources.Exit);
        static SoundPlayer sound_win = new SoundPlayer(Properties.Resources.Win);
        static SoundPlayer sound_check = new SoundPlayer(Properties.Resources.CheckSound);
        static bool soundEnable = true;

        public static void soud_on()
        {
            soundEnable = true;
        }
        public static void sound_off()
        {
            soundEnable = false;
        }

        public static void play_start()
        {
            if (soundEnable)
                sound_start.Play();
        }
        public static void play_exit()
        {
            if (soundEnable)
                sound_exit.Play();
        }
        public static void play_win()
        {
            if (soundEnable)
                sound_win.Play();
        }
        public static void play_check()
        {
            if (soundEnable)
                sound_check.Play();
        }
    }
}
