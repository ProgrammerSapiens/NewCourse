namespace DelegatesAndEvents_Friday
{
    internal class Program
    {
        public delegate int MathOperationsHandler(int x, int y);
        static async Task Main(string[] args)
        {
            //First task
            MathOperationsHandler mathOps = First.Multiply;
            Console.WriteLine(mathOps(5, 7));
            mathOps = First.ShowAndMultiply;
            Console.WriteLine(mathOps(5, 7));
            mathOps = First.CheckAndMultiply;
            Console.WriteLine(mathOps(5, 0));

            //Second task
            StateNotifier stateNotifier = new StateNotifier();
            stateNotifier.StateChanged += LoggerSubscriber.ShowStateChange;
            stateNotifier.StateChanged += LoggerSubscriber.Logger;
            stateNotifier.ChangeState();
            stateNotifier.ChangeState();

            //Third task
            string content = await FileLoader.LoadDataAsync();
            Console.WriteLine(content);
        }
    }
}
