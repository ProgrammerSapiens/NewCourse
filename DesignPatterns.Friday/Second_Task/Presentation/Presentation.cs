using DesignPatterns.Friday.Second_Task.BusinessLogic;

namespace DesignPatterns.Friday.Second_Task.Presentation
{
    public class Presentation
    {
        private readonly IOrderService OrderService;
        private readonly IProductService ProductService;

        public Presentation(IOrderService orderService, IProductService productService)
        {
            OrderService = orderService;
            ProductService = productService;
        }

        public void AddProducts(int productId, string productName, double price)
        {
            if (ProductService.AddProduct(productId, productName, price))
            {
                Console.WriteLine("The product was successfully added");
            }
            else
            {
                Console.WriteLine("Something went wrong. The product wasn't added");
            }
        }
        public void DeleteProductById(int productId)
        {
            if (ProductService.DeleteProductById(productId))
            {
                Console.WriteLine("The product was successfully deleted");
            }
            else
            {
                Console.WriteLine("Something went wrong. The product wasn't deleted");
            }
        }

        public void AddOrder(int orderId, List<int> productsId)
        {
            if (OrderService.AddOrder(orderId, productsId))
            {
                Console.WriteLine("The order was successfully added");
            }
            else
            {
                Console.WriteLine("Something went wrong. The order wasn't added");
            }
        }
        public void DeleteOrderById(int orderId)
        {
            if (OrderService.DeleteOrderById(orderId))
            {
                Console.WriteLine("The order was successfully deleted");
            }
            else
            {
                Console.WriteLine("Something went wrong. The order wasn't deleted");
            }
        }
        public void ShowOrderById(int orderId)
        {
            List<string> order = OrderService.GetOrderById(orderId);
            foreach (string product in order)
            {
                Console.WriteLine(product);
            }
        }
    }
}
