namespace NetFramework_Wednesday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First task
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int number in numbers) Console.WriteLine(number);

            //Second task
            List<string> books = new List<string>();
            books.Add("Harry Potter and the halfblood prince");
            books.Add("Lord of the rings");
            books.Add("For whom the bell tolls");
            foreach (string book in books) Console.WriteLine(book);

            //Third task
            Random rand = new Random();
            int[] randomNumbers = new int[10];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rand.Next(1, 100);
            }
            Array.Sort(randomNumbers);
            foreach (int number in randomNumbers) Console.WriteLine(number);

            //Fourth task
            List<string> contacts = new List<string>();
            contacts.Add("Michelle");
            contacts.Add("Thomas");
            contacts.Add("Emmanuelle");
            if (contacts.Contains("Thomas")) Console.WriteLine("Element is exist");
            else Console.WriteLine("Element does not exist");

            //Fifth task
            List<int> newNumbers = new List<int>();
            for (int i = 8; i <= 18; i++)
                newNumbers.Add(i);
            for (int i = newNumbers.Count - 1; i >= 0; i--)
            {
                if (newNumbers[i] < 10) newNumbers.Remove(newNumbers[i]);
            }
            foreach (int number in newNumbers) Console.WriteLine(number);
        }
    }
}
