namespace NetFramework.Monday.Third_Task
{
    static internal class LineCounterDemo
    {
        private const string filePath = "./Third_Task/example_line_count.txt";

        static public void LinesCounter()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    ++count;
                }
            }
            Console.WriteLine($"The file contains {count} lines");
        }
    }
}
