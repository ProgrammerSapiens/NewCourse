namespace DesignPatterns.Monday
{
    internal interface IOrderRepository
    {
        public void AddOrder(Order order);
        public Order GetOrderById(int orderId);
        public List<Order> GetAllOrders();
        public void RemoveOrder(int orderId);
    }
}
