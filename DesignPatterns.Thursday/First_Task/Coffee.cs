namespace DesignPatterns.Thursday.First_Task
{
    internal class Coffee : IBeverage
    {
        private double CoffeeCost { get; set; }

        public Coffee(double coffeeCost)
        {
            CoffeeCost = coffeeCost;
        }

        public double GetCost()
        {
            return CoffeeCost;
        }
    }
}
