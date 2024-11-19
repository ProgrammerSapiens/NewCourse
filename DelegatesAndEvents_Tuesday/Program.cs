namespace DelegatesAndEvents_Tuesday
{
    internal class Program
    {
        public delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Operation operation = Add;
            int x = 10;
            int y = 12;
            Console.WriteLine($"Addition = {operation(x, y)}");

            operation = Subtract;
            Console.WriteLine($"Subtraction = {operation(x, y)}");

            operation = Multiply;
            Console.WriteLine($"Multiplication = {operation(x, y)}");

            operation = Divide;
            Console.WriteLine($"Division = {operation(x, y)}");
        }
        static public int Add(int x, int y) => x + y;
        static public int Subtract(int x, int y) => x - y;
        static public int Multiply(int x, int y) => x * y;
        static public int Divide(int x, int y) => x / y;

    }
}
