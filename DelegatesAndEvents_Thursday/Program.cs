using System.Threading.Channels;

namespace DelegatesAndEvents_Thursday
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var waiterTask = Waiter();
            var calculateSumTask = CalculateSumAsync(5, 7);
            var requestSimulationTask = RequestSimulation(3);
            var asyncExceptionsTask = AsyncExceptions(4, 7);

            //Fifth task
            await Task.WhenAll(waiterTask, calculateSumTask, requestSimulationTask, asyncExceptionsTask);
        }

        //First task
        static async Task Waiter()
        {
            await Task.Delay(2000);
            Console.WriteLine("Прошло 2 секунды");
        }

        //Second task
        static async Task CalculateSumAsync(int a, int b)
        {
            int result = await Task.Run(() => a + b);
            Console.WriteLine(result);
        }

        //Third task
        static async Task RequestSimulation(int waitingTime)
        {
            await Task.Delay(waitingTime * 1000);
            Console.WriteLine("Данные получены");
        }

        //Fourth task
        static async Task AsyncExceptions(double a, double b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                double result = await Task.Run(() => a / b);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                await Console.Out.WriteLineAsync("Нельзя делить на ноль");
            }
        }
    }
}
