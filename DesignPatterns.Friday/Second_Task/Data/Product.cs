namespace DesignPatterns.Friday.Second_Task.Data
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double ProductPrice { get; set; }

        public Product() { }

        public Product(int id, string name, double price)
        {
            ProductId = id;
            ProductName = name;
            ProductPrice = price;
        }
    }
}
