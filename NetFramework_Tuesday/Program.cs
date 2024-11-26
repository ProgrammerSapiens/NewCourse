using NetFramework_Tuesday.Fifth_Task;
using NetFramework_Tuesday.First_Task;
using NetFramework_Tuesday.Fourth_Task;
using NetFramework_Tuesday.Second_Task;
using NetFramework_Tuesday.Third_Task;

namespace NetFramework_Tuesday
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //First task
            LineNumbering.ProcessFile();

            //Second task
            BufferedDataWriter.WriteData();

            //Third task
            await AsyncFileReader.ReadFileAsync();

            //Fourth task
            LargeFileFilter.FilterLines("C#");

            //Fifth task
            await CsvParser.ParseAndTransformAsync();
        }
    }
}
