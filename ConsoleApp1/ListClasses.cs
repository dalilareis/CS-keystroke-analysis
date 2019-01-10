
namespace SentimentAnalysis
{
    class KeystrokeEvent
    {
        private int timestamp;
        private string character;

        public KeystrokeEvent(int timestamp, string character)
        {
            this.timestamp = timestamp;
            this.character = character;
        }
        public int getTimestamp()
        {
            return this.timestamp;
        }

        public string getCharacter()
        {
            return this.character;
        }
        public void setTimestamp(int timestamp)
        {
            this.timestamp = timestamp;
        }

        public void setCharacter(string character)
        {
            this.character = character;
        }
    }
    class PairEvents
    {
        private int timedif;
        private string firstkey;
        private string secondkey;
        private string keygroup_pair;

        public PairEvents(int timedif, string firstkey, string secondkey, string keygroup_pair)
        {
            this.timedif = timedif;
            this.firstkey = firstkey;
            this.secondkey = secondkey;
            this.keygroup_pair = keygroup_pair;
        }

        public int getTimedif()
        {
            return timedif;
        }

        public string getFirstkey()
        {
            return firstkey;
        }

        public string getSecondkey()
        {
            return secondkey;
        }

        public string getKeygroup_pair()
        {
            return keygroup_pair;
        }
    }
    class WordEvents
    {
        private int deltatime;
        private string word;
        private int backspace_found;
        private int word_size;

        public WordEvents(int deltatime, string word, int backspace_found, int word_size)
        {
            this.deltatime = deltatime;
            this.word = word;
            this.backspace_found = backspace_found;
            this.word_size = word_size;
        }

        public int getdeltatime()
        {
            return deltatime;
        }

        public string getword()
        {
            return word;
        }

        public int getbackspace_found()
        {
            return backspace_found;
        }

        public int getword_size()
        {
            return word_size;
        }
    }
    class Emotion
    {
        private int Positive;
        private int Negative;
        private int Anger;
        private int Anticipation;
        private int Disgust;
        private int Fear;
        private int Joy;
        private int Sadness;
        private int Surprise;
        private int Trust;

        public Emotion(int Positive, int Negative, int Anger, int Anticipation, int Disgust, int Fear, int Joy, int Sadness, int Surprise, int Trust)
        {
            this.Positive = Positive;
            this.Negative = Negative;
            this.Anger = Anger;
            this.Anticipation = Anticipation;
            this.Disgust = Disgust;
            this.Fear = Fear;
            this.Joy = Joy;
            this.Sadness = Sadness;
            this.Surprise = Surprise;
            this.Trust = Trust;
        }
        public int getPositive()
        {
            return Positive;
        }
        public int getNegative()
        {
            return Negative;
        }
        public int getAnger()
        {
            return Anger;
        }
        public int getAnticipation()
        {
            return Anticipation;
        }
        public int getDisgust()
        {
            return Disgust;
        }
        public int getFear()
        {
            return Fear;
        }
        public int getJoy()
        {
            return Joy;
        }
        public int getSadness()
        {
            return Sadness;
        }
        public int getSurprise()
        {
            return Surprise;
        }
        public int getTrust()
        {
            return Trust;
        }
    }
}
