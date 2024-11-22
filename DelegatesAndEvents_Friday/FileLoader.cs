using System.Runtime.CompilerServices;

namespace DelegatesAndEvents_Friday
{
    static internal class FileLoader
    {
        private const string filePath = "C:\\Users\\PotatoKiller\\source\\repos\\NewCourse\\DelegatesAndEvents_Friday\\Example.txt";
        static public async Task<string> LoadDataAsync()
        {
            if (string.IsNullOrEmpty(filePath))
                throw new ArgumentException("File path connot be null or empty.");

            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = await reader.ReadToEndAsync();
                return content;
            }
        }
    }
}
