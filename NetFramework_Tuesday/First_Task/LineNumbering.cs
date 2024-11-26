namespace NetFramework_Tuesday.First_Task
{
    static internal class LineNumbering
    {
        private const string FirstFilePath = "C:/Users/PotatoKiller/source/repos/NewCourse/NetFramework_Tuesday/First_Task/input1.txt";
        private const string SecondFilePath = "C:/Users/PotatoKiller/source/repos/NewCourse/NetFramework_Tuesday/First_Task/output1.txt";

        static public void ProcessFile()
        {
            List<string> lines = new List<string>();
            int count = 0;
            using (StreamReader reader = new StreamReader(FirstFilePath))
            {
                string content;
                while ((content = reader.ReadLine()) != null)
                {
                    lines.Add(++count + ". " + content);
                }
            }
            if (File.Exists(SecondFilePath)) File.Delete(SecondFilePath);
            else File.Create(SecondFilePath).Close();
            using (StreamWriter writer = new StreamWriter(SecondFilePath, true))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
