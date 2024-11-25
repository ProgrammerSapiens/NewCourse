namespace NetFramework.Monday.First_Task
{
    static internal class FileReaderDemo
    {
        private const string filePath = "./First_Task/example_read.txt";

        static public void TextReader()
        {
            string content;
            using (StreamReader reader = new StreamReader(filePath))
            {
                content = reader.ReadToEnd();
            }
            Console.WriteLine(content);
        }
    }
}
