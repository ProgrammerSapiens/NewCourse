namespace NetFramework_Friday.Fifth_Task
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    internal class BankAccount
    {
        private double Balance { get; set; }
        private double WithdrawalLimit { get; set; }

        public BankAccount()
        {
            Balance = 0;
            WithdrawalLimit = 0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"The account has been replenished, the current amount: {Balance}");
        }

        public void Withdraw(double amount)
        {
            try
            {
                if (amount > WithdrawalLimit) { throw new InsufficientFundsException("The amount exceeds the established limit"); }

                double result = Balance - amount;
                if (result < 0) { throw new InsufficientFundsException("The amount exceeds the amount on the account"); }

                Balance = result;
                Console.WriteLine($"The amount was successfully withdrawn from the account.The amount on the account: {Balance}");
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SetWithdrawalLimit(double limit)
        {
            try
            {
                if (limit > Balance) { throw new InsufficientFundsException("The limit exceeds the amount on the account"); }
                WithdrawalLimit = limit;
                Console.WriteLine("The limit has been successfully set");
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
