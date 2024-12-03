namespace DesignPatterns.Wednesday.First_Task
{
    public sealed class Logger
    {
        private static Logger? _instance = null;
        private static readonly object _lock = new object();

        private Logger() { }

        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
                return _instance;
            }
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
