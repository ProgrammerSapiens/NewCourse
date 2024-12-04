namespace DesignPatterns.Friday.Second_Task.Data
{
    public interface IProductRepository
    {
        bool AddProduct(int productId, string productName, double productPrice);
        bool GetProductById(int productId, out Product product);
        bool DeleteProductById(int productId);
    }
}
