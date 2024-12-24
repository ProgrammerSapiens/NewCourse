using DesignPatterns.Wednesday.First_Task;
using DesignPatterns.Wednesday.Second_Task;
using DesignPatterns.Wednesday.Third_Task;

namespace DesignPatterns.Wednesday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First task
            Logger logger = Logger.Instance;
            logger.LogMessage("It's singleton");
            Logger newLogger = Logger.Instance;
            newLogger.LogMessage("It's singleton");
            Console.WriteLine("They are the same object? - " + Object.ReferenceEquals(logger, newLogger));

            //Second task
            ConfigurationManager configurationManager = ConfigurationManager.Instance;
            configurationManager.SetSetting("Programming language", "C#");
            configurationManager.SetSetting("Nullable", "Enable");
            Console.WriteLine(configurationManager.GetSetting("Nullable"));

            //Third task
            DatabaseConnection databaseConnection = DatabaseConnection.Instance;
            databaseConnection.Connect();
            databaseConnection.Disconnect();

        }
    }
}
