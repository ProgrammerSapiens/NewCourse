using System.Diagnostics.Metrics;

namespace NetFramework_Thursday.Second_Task
{
    static internal class WordsCounter
    {
        private const string filePath = "C:/Users/PotatoKiller/source/repos/NewCourse/NetFramework_Thursday/Second_Task/text.txt";

        static public int CountWords(string word)
        {
            char[] chars = { ',', '.', ' ' };
            string[] wordsInText;
            Dictionary<string, int> amountOfWords = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string text = reader.ReadToEnd();
                wordsInText = text.Split(chars);
            }

            foreach (var w in wordsInText)
            {
                if (!amountOfWords.ContainsKey(w))
                {
                    amountOfWords[w] = 1;
                }
                else
                {
                    amountOfWords[w]++;
                }
            }

            if (amountOfWords.ContainsKey(word))
            {
                return amountOfWords[word];
            }
            return 0;
        }
    }
}
