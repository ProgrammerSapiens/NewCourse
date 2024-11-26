namespace NetFramework_Tuesday.Third_Task
{
    static internal class AsyncFileReader
    {
        private const string FilePath = "C:/Users/PotatoKiller/source/repos/NewCourse/NetFramework_Tuesday/Third_Task/async_input.txt";

        static public async Task ReadFileAsync()
        {
            const int bufferSize = 1024;
            char[] buffer = new char[bufferSize];

            using (StreamReader sr = new StreamReader(FilePath))
            {
                int readChars;
                while ((readChars = await sr.ReadAsync(buffer, 0, bufferSize)) > 0)
                {
                    string content = new string(buffer, 0, readChars);
                    Console.WriteLine(content);
                }
            }
        }
    }
}
