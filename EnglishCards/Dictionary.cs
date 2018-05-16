using System.IO;

namespace EnglishCards
{
    class Dictionary
    {
        int total = 0;

        string[] english, russian;
        string[] audioEng, audioRus;
        string[] image, video;

        public Dictionary()
        {
            Init();
        }

        public int Total()
        {
            return total;
        }

        public string English(int nr)
        {
            if (nr < 0 || nr > total) return "";
            return english[nr];
        }

        public string Russian(int nr)
        {
            if (nr < 0 || nr > total) return "";
            return russian[nr];
        }

        public string AudioEng(int nr)
        {
            if (nr < 0 || nr > total) return "";
            return audioEng[nr];
        }

        public string AudioRus(int nr)
        {
            if (nr < 0 || nr > total) return "";
            return audioRus[nr];
        }

        public string Image(int nr)
        {
            if (nr < 0 || nr > total) return "";
            return image[nr];
        }

        public string Video(int nr)
        {
            if (nr < 0 || nr > total) return "";
            return video[nr];
        }

        private void Init()
        {
            total = 0;
            DirectoryInfo di = new DirectoryInfo("data/text/");
            FileInfo[] info = di.GetFiles("*.txt", SearchOption.TopDirectoryOnly);
            total = info.Length;

            english = new string[total];
            russian = new string[total];
            audioEng = new string[total];
            audioRus = new string[total];
            image = new string[total];
            video = new string[total];
            int j = 0;

            foreach (FileInfo file in info)
            {
                string filename = file.FullName;
                string name = file.Name.Replace(".txt", "");
                string[] lines = File.ReadAllLines(filename);
                english[j] = lines[0];
                russian[j] = lines[1];
                audioEng[j] = "data/english/" + name + ".mp3";
                audioRus[j] = "data/russian/" + name + ".mp3";
                if (!File.Exists(audioEng[j])) audioEng[j] = "";
                if (!File.Exists(audioRus[j])) audioRus[j] = "";
                image[j] = "data/images/" + name + ".jpg";
                video[j] = "data/video/" + name + ".mp4";
                if (!File.Exists(image[j])) image[j] = "";
                if (!File.Exists(video[j])) video[j] = "";
                j++;
            }
        }
    }
}
