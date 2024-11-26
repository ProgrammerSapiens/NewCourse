namespace NetFramework_Tuesday.Fifth_Task
{
    static internal class CsvParser
    {
        private const string FirstFilePath = "C:/Users/PotatoKiller/source/repos/NewCourse/NetFramework_Tuesday/Fifth_Task/data.txt";
        private const string SecondFilePath = "C:/Users/PotatoKiller/source/repos/NewCourse/NetFramework_Tuesday/Fifth_Task/transformed_data.txt";

        static public async Task ParseAndTransformAsync()
        {
            List<string> elements = new List<string>();

            using (var reader = new StreamReader(FirstFilePath))
            {
                string? headerLine = await reader.ReadLineAsync();
                elements.Add(headerLine);

                string? line;
                string[] parts;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    parts = line.Split(',');
                    if (parts.Length == 3 && int.TryParse(parts[1], out int age))
                    {
                        parts[1] = (age + 1).ToString();
                        string newLine = string.Join(", ", parts);
                        elements.Add(newLine);
                    }
                }
            }

            using (var fs = new FileStream(SecondFilePath, FileMode.OpenOrCreate))
            using (var bs = new BufferedStream(fs))
            using (var writer = new StreamWriter(bs))
            {
                foreach (var element in elements)
                {
                    await writer.WriteLineAsync(element);
                }
            }
        }
    }
}
