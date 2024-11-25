namespace NetFramework.Monday.Fifth_Task
{
    static internal class ReverseLineDisplayDemo
    {
        private const string filePath = "C:/Users/PotatoKiller/source/repos/NewCourse/NetFramework.Monday/Fifth_Task/example_reverse.txt";

        static public void TextReverser()
        {
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                    lines.Add(line);
            }

            lines.Reverse();

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
