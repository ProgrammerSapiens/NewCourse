namespace DesignPatterns.Tuesday.CoffeeMachine
{
    internal class CoffeeMachineFacade
    {
        private readonly Grinder grinder;
        private readonly Brewer brewer;
        private readonly MilkSteamer milkSteamer;

        public CoffeeMachineFacade(Grinder grinder, Brewer brewer, MilkSteamer milkSteamer)
        {
            this.grinder = grinder;
            this.brewer = brewer;
            this.milkSteamer = milkSteamer;
        }

        public void MakeCappuccino()
        {
            grinder.Grind();
            brewer.Brew();
            milkSteamer.Steam();
        }
    }
}
