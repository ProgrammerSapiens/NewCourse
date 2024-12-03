namespace DesignPatterns.Thursday.Second_Task
{
    public class BlackAndWhiteFilterDecorator : FilterDecorator
    {
        public BlackAndWhiteFilterDecorator(IImage image) : base(image) { }

        public override string ApplyFilter()
        {
            return "Black and white " + base.ApplyFilter().ToLower();
        }
    }
}
