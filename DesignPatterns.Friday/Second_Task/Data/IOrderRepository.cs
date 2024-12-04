namespace DesignPatterns.Friday.Second_Task.Data
{
    public interface IOrderRepository
    {
        bool AddOrder(int orderId, List<int> productsId, double price);
        bool GetOrderById(int orderId, out Order order);
        bool DeleteOrderById(int orderId);
    }
}
