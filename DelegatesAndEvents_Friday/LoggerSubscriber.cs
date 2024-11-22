using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents_Friday
{
    static internal class LoggerSubscriber
    {
        static public void ShowStateChange(string message)
        {
            Console.WriteLine($"The state has been changed. {message}");
        }
        static public void Logger(string message)
        {
            Console.WriteLine(message);
        }
    }
}
