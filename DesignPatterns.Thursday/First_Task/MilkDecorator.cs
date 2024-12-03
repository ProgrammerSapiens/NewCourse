namespace DesignPatterns.Thursday.First_Task
{
    internal class MilkDecorator : BeverageDecorator
    {
        private double MilkCost { get; set; }

        public MilkDecorator(IBeverage beverage, double cost) : base(beverage)
        {
            MilkCost = cost;
        }

        public override double GetCost()
        {
            return base.GetCost() + MilkCost;
        }
    }
}
