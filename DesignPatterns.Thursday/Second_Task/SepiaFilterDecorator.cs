namespace DesignPatterns.Thursday.Second_Task
{
    public class SepiaFilterDecorator : FilterDecorator
    {
        public SepiaFilterDecorator(IImage image) : base(image) { }

        public override string ApplyFilter()
        {
            return "Sepia " + base.ApplyFilter().ToLower();
        }
    }
}
