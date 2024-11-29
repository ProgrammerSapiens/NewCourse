namespace NetFramework_Friday.First_Task
{
    static internal class DivisionHandler
    {
        static public void PerformDivision(int numerator, int denominator)
        {
            int result = 0;
            try
            {
                result = numerator / denominator;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can not divide by zero");
                result = 0;
            }
            finally
            {
                Console.WriteLine($"Result: {result}");
            }
        }
    }
}
