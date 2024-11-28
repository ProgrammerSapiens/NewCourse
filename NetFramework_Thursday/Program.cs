using NetFramework_Thursday.First_Task;
using NetFramework_Thursday.Second_Task;

namespace NetFramework_Thursday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First task
            ContactBook contactBook = new ContactBook();
            contactBook.AddContact("Elle", "+45433234421");
            contactBook.AddContact("Michael", "+45456234321");
            contactBook.AddContact("Sophie", "+45533784421");
            Console.WriteLine(contactBook.GetPhoneNumber("Elle"));
            contactBook.RemoveContact("Elle");
            Console.WriteLine(contactBook.GetPhoneNumber("Elle"));

            //Second task
            Console.WriteLine(WordsCounter.CountWords("Today"));
        }
    }
}
