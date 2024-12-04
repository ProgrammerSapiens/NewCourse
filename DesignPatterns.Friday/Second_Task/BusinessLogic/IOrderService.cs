namespace DesignPatterns.Friday.Second_Task.BusinessLogic
{
    public interface IOrderService
    {
        bool AddOrder(int orderId, List<int> productsId);
        List<string> GetOrderById(int orderId);
        bool DeleteOrderById(int orderId);
    }
}
