namespace DesignPatterns.Thursday.First_Task
{
    internal class SugarDecorator : BeverageDecorator
    {
        private double SugarCost { get; set; }

        public SugarDecorator(IBeverage beverage, double cost) : base(beverage)
        {
            SugarCost = cost;
        }

        public override double GetCost()
        {
            return base.GetCost() + SugarCost;
        }
    }
}
