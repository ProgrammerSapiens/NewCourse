namespace DesignPatterns.Thursday.Second_Task
{
    public abstract class FilterDecorator : IImage
    {
        protected IImage image;

        public FilterDecorator(IImage image)
        {
            this.image = image;
        }

        public virtual string ApplyFilter()
        {
            return image.ApplyFilter();
        }
    }
}
