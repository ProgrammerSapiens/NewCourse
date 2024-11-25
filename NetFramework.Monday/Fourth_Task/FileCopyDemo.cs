namespace NetFramework.Monday.Fourth_Task
{
    static internal class FileCopyDemo
    {
        private const string filePath = "./Fourth_Task/example_source.txt";
        private const string destinationFilePath = "C:/Users/PotatoKiller/source/repos/NewCourse/NetFramework.Monday/Fourth_Task/copied_file.txt";

        static public void FileCopier()
        {
            string text;
            if (!File.Exists(filePath))
            {
                File.Create(destinationFilePath);
                File.Copy(filePath, destinationFilePath);
            }
            else
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    text = reader.ReadToEnd();
                }
                using (StreamWriter writer = new StreamWriter(destinationFilePath))
                {
                    writer.WriteLine(text);
                }
            }
        }
    }
}
