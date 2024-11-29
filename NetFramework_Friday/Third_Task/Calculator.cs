using System.Runtime.InteropServices;

namespace NetFramework_Friday.Third_Task
{
    static internal class Calculator
    {
        static public int Calculate(string expression)
        {
            int result = 0;
            Queue<int> numbers = new Queue<int>();
            Queue<char> operationsSequence = new Queue<char>();

            try
            {
                string quantity = String.Empty;
                if (string.IsNullOrEmpty(expression)) { throw new FormatException(); }

                foreach (char element in expression)
                {
                    if (char.IsDigit(element))
                    {
                        quantity += element;
                    }
                    else if (element == '+' || element == '-')
                    {
                        operationsSequence.Enqueue(element);
                        numbers.Enqueue(int.Parse(quantity));
                        quantity = String.Empty;
                    }
                    else { throw new FormatException(); }
                }
                if (!string.IsNullOrEmpty(quantity))
                {
                    numbers.Enqueue(int.Parse(quantity));
                }

                if (numbers.Count - 1 != operationsSequence.Count) { throw new FormatException(); }

                result += numbers.Dequeue();
                while (operationsSequence.Count > 0)
                {
                    char operation = operationsSequence.Dequeue();
                    if (operation == '+')
                    {
                        result += numbers.Dequeue();
                    }
                    else if (operation == '-')
                    {
                        result -= numbers.Dequeue();
                    }
                    else { throw new FormatException(); }
                }

                return result;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format of expression, try again");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
