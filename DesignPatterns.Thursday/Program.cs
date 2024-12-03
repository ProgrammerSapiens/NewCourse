using DesignPatterns.Thursday.First_Task;
using DesignPatterns.Thursday.Second_Task;

namespace DesignPatterns.Thursday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First task
            IBeverage coffee = new Coffee(12.22);
            IBeverage sugar = new SugarDecorator(coffee, 2.1);
            IBeverage milk = new MilkDecorator(sugar, 5.2);

            Console.WriteLine(milk.GetCost());

            //Second task
            IImage baseImage = new BaseImage();
            IImage blackAndWhiteFilter = new BlackAndWhiteFilterDecorator(baseImage);
            IImage sepiaFilter = new SepiaFilterDecorator(baseImage);

            Console.WriteLine(blackAndWhiteFilter.ApplyFilter());
            Console.WriteLine(sepiaFilter.ApplyFilter());
        }
    }
}
