using DelegatesAndEvents_Wednesday.Second;

namespace DelegatesAndEvents_Wednesday
{
    internal class Program_Two
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            NotificationService notificationService = new NotificationService();

            productManager.ProductAdded += notificationService.HandleProductAdded;
            productManager.ProductUpdated += notificationService.HandleProductUpdated;
            productManager.ProductRemoved += notificationService.HandleProductRemoved;

            var product1 = new Product { Name = "Товар 1", Price = 100 };
            var product2 = new Product { Name = "Товар 2", Price = 200 };

            productManager.AddProduct(product1);
            productManager.AddProduct(product2);
            productManager.UpdateProduct("Товар 1", new Product { Name = "Обновленный Товар 1", Price = 120 });
            productManager.RemoveProduct("Товар 2");
        }
    }
}