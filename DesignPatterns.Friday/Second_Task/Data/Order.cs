namespace DesignPatterns.Friday.Second_Task.Data
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<int> ProductsId;
        public double OrderPrice { get; set; }

        public Order()
        {
            ProductsId = new List<int>();
        }

        public Order(int orderId, List<int> productsId, double orderPrice)
        {
            OrderId = orderId;
            ProductsId = productsId;
            OrderPrice = orderPrice;
        }
    }
}
