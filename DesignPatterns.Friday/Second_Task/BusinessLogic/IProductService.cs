namespace DesignPatterns.Friday.Second_Task.BusinessLogic
{
    public interface IProductService
    {
        bool AddProduct(int productId, string productName, double productPrice);
        string GetProductById(int productId, out double productPrice);
        bool DeleteProductById(int productId);
    }
}
