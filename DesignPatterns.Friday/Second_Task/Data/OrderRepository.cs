namespace DesignPatterns.Friday.Second_Task.Data
{
    public class OrderRepository : IOrderRepository
    {
        private List<Order> orders;

        public OrderRepository()
        {
            orders = new List<Order>();
        }

        public bool AddOrder(int orderId, List<int> productsId, double orderPrice)
        {
            int orderIdIndex = orders.FindIndex(x => x.OrderId == orderId);

            if (orderIdIndex == -1)
            {
                Order order = new Order(orderId, productsId, orderPrice);
                orders.Add(order);
                return true;
            }
            return false;
        }

        public bool DeleteOrderById(int orderId)
        {
            int orderIdIndex = orders.FindIndex(x => x.OrderId == orderId);

            if (orderIdIndex != -1)
            {
                orders.RemoveAt(orderIdIndex);
                return true;
            }
            return false;
        }

        public bool GetOrderById(int orderId, out Order order)
        {
            int orderIdIndex = orders.FindIndex(x => x.OrderId == orderId);

            if (orderIdIndex != -1)
            {
                order = orders[orderIdIndex];
                return true;
            }
            order = new Order();
            return false;
        }
    }
}
