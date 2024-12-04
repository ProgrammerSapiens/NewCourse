using DesignPatterns.Friday.Second_Task.Data;

namespace DesignPatterns.Friday.Second_Task.BusinessLogic
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository OrderRepository;
        private readonly IProductService ProductRepository;

        public OrderService(IOrderRepository orderRepository, IProductService productRepository)
        {
            OrderRepository = orderRepository;
            ProductRepository = productRepository;
        }

        public bool AddOrder(int orderId, List<int> productsId)
        {
            if (orderId > 0 && productsId.Count > 0)
            {
                List<int> checkedProductsId = new List<int>();
                double orderPrice = 0;

                foreach (int productId in productsId)
                {
                    string productString = ProductRepository.GetProductById(productId, out double productPrice);
                    if (!string.IsNullOrEmpty(productString))
                    {
                        checkedProductsId.Add(productId);
                        orderPrice += productPrice;
                    }
                }

                if (OrderRepository.AddOrder(orderId, checkedProductsId, orderPrice))
                    return true;
            }
            return false;
        }

        public bool DeleteOrderById(int orderId)
        {
            if (OrderRepository.DeleteOrderById(orderId))
                return true;
            return false;
        }

        public List<string> GetOrderById(int orderId)
        {
            List<string> products = new List<string>();

            if (OrderRepository.GetOrderById(orderId, out Order order))
            {
                products.Add($"Order Id: {orderId}");

                foreach (int productId in order.ProductsId)
                {
                    string productString = ProductRepository.GetProductById(productId, out double productPrice);
                    if (!string.IsNullOrEmpty(productString))
                    {
                        products.Add(productString);
                    }
                }

                products.Add($"Order price: {order.OrderPrice}");
                return products;
            }
            return new List<string>();
        }
    }
}
