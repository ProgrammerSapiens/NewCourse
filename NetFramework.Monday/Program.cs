using NetFramework.Monday.Fifth_Task;
using NetFramework.Monday.First_Task;
using NetFramework.Monday.Fourth_Task;
using NetFramework.Monday.Second_Task;
using NetFramework.Monday.Third_Task;

namespace NetFramework.Monday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First task
            FileReaderDemo.TextReader();

            //Second task
            FileWriterDemo.TextWriter("Write this text to a file");
            FileWriterDemo.TextWriter("And add this text below");

            //Third task
            LineCounterDemo.LinesCounter();

            //Fourth task
            FileCopyDemo.FileCopier();

            //Fifth task
            ReverseLineDisplayDemo.TextReverser();
        }
    }
}
