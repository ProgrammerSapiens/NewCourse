using NetFramework_Friday.Fifth_Task;
using NetFramework_Friday.First_Task;
using NetFramework_Friday.Fourth_Task;
using NetFramework_Friday.Second_Task;
using NetFramework_Friday.Third_Task;

namespace NetFramework_Friday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First task
            DivisionHandler.PerformDivision(3, 2);

            //Second task
            FileReader.ReadFile();

            //Third task
            Console.WriteLine(Calculator.Calculate("5+2-6-1"));

            //Fourth task
            Student student = new Student();
            student.AddStudent("Adam", 18);
            student.AddStudent("Alisha", -22);

            //Fifth task
            BankAccount account = new BankAccount();
            account.Deposit(500);
            account.SetWithdrawalLimit(300);
            account.Withdraw(250);
        }
    }
}
