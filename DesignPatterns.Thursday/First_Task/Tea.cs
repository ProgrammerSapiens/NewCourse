namespace DesignPatterns.Thursday.First_Task
{
    internal class Tea : IBeverage
    {
        private double TeaCost { get; set; }

        public Tea(double teaCost)
        {
            TeaCost = teaCost;
        }

        public double GetCost()
        {
            return TeaCost;
        }
    }
}
