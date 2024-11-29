namespace NetFramework_Friday.Second_Task
{
    static internal class FileReader
    {
        private const string filePath = "./Second_Task/example.txt";

        static public void ReadFile()
        {
            string text = "";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    text = reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found");
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            finally
            {
                Console.WriteLine(text);
            }
        }
    }
}
