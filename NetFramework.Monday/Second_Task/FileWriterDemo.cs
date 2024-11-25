namespace NetFramework.Monday.Second_Task
{
    static internal class FileWriterDemo
    {
        private const string filePath = "C:/Users/PotatoKiller/source/repos/NewCourse/NetFramework.Monday/Second_Task/example_write.txt";

        static public void TextWriter(string text)
        {
            try
            {
                bool shouldAppend = true;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string content = reader.ReadToEnd();
                    shouldAppend = !content.Contains(text);
                }
                if (shouldAppend)
                {
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(text);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occured: {e.Message}");
            }
        }
    }
}
