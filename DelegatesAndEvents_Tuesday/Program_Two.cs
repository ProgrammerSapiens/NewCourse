namespace DelegatesAndEvents_Tuesday
{
    internal class Program_Two
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 6, 4, 87, 5, 6, 222, 5, 65, 2, 4 };
            List<string> list2 = new List<string>() { "word", "longlongword", "Another string" };
            List<string> list3 = new List<string>() { "word", "longlongword", "Another string" };

            Predicate<int> isOdd = (x) => x % 2 == 0;
            Predicate<string> isCapital = (x) => char.IsUpper(x[0]);
            Predicate<string> isLong = (x) => x.Length > 7;

            list = FilterList<int>(list, isOdd);
            foreach (int i in list)
                Console.WriteLine(i);
            Console.WriteLine();

            list2 = FilterList<string>(list2, isCapital);
            foreach (string i in list2)
                Console.WriteLine(i);
            Console.WriteLine();

            list3 = FilterList<string>(list3, isLong);
            foreach (string i in list3)
                Console.WriteLine(i);
            Console.WriteLine();

            //Second task
            list = new List<int>() { 1, 6, 4, 87, 5, 6, 222, 5, 65, 2, 4 };
            Action<int> action = x => Console.WriteLine(x + 5);
            ProcessList<int>(list, action);

        }
        static List<T> FilterList<T>(List<T> items, Predicate<T> condition)
        {
            List<T> result = new List<T>();
            foreach (T item in items)
            {
                if (condition(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        static void ProcessList<T>(List<T> items, Action<T> action)
        {
            foreach (T item in items)
            { action(item); }
        }

    }
}