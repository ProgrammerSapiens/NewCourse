namespace DesignPatterns.Thursday.First_Task
{
    public abstract class BeverageDecorator : IBeverage
    {
        protected IBeverage Beverage;

        public BeverageDecorator(IBeverage beverage)
        {
            Beverage = beverage;
        }

        public virtual double GetCost()
        {
            return Beverage.GetCost();
        }
    }
}
