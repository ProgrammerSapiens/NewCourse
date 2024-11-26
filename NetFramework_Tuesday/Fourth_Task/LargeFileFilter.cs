namespace NetFramework_Tuesday.Fourth_Task
{
    static internal class LargeFileFilter
    {
        private const string FilePath = "C:/Users/PotatoKiller/source/repos/NewCourse/NetFramework_Tuesday/Fourth_Task/large_file.txt";

        static public void FilterLines(string keyword)
        {
            List<string> resultLines = new List<string>();

            using (StreamReader reader = new StreamReader(FilePath))
            {
                string? content;
                while ((content = reader.ReadLine()) != null)
                {
                    if (content.Contains(keyword))
                        resultLines.Add(content);
                }
            }

            foreach (string line in resultLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
