namespace DelegatesAndEvents_Friday
{
    static internal class First
    {
        static public int Multiply(int x, int y)
        {
            return x * y;
        }

        static public int ShowAndMultiply(int x, int y)
        {
            Console.WriteLine($"You entered {x} and {y}\r");
            return x * y;
        }

        static public int CheckAndMultiply(int x, int y)
        {
            if (y == 0 || x == 0)
                Console.WriteLine("You entered 0. You will pay for that\r");
            return x * y;
        }
    }
}
