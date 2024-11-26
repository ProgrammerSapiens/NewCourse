namespace NetFramework_Tuesday.Second_Task
{
    static internal class BufferedDataWriter
    {
        private const string FilePath = "C:/Users/PotatoKiller/source/repos/NewCourse/NetFramework_Tuesday/Second_Task/bufferedData.txt";

        static public void WriteData()
        {
            Random random = new Random();

            using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            using (BufferedStream bs = new BufferedStream(fs, bufferSize: 8192))
            using (StreamWriter sw = new StreamWriter(bs))
            {
                for (int i = 0; i < 1000; i++)
                    sw.WriteLine(random.Next(1, 1000));
            }

        }
    }
}
