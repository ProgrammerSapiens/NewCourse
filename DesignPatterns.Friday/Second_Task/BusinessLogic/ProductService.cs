using DesignPatterns.Friday.Second_Task.Data;

namespace DesignPatterns.Friday.Second_Task.BusinessLogic
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository ProductRepository;

        public ProductService(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }

        public bool AddProduct(int productId, string productName, double productPrice)
        {
            if (productId > 0 && productName != null && productPrice != 0)
            {
                if (ProductRepository.AddProduct(productId, productName, productPrice))
                    return true;
            }
            return false;
        }

        public bool DeleteProductById(int productId)
        {
            if (ProductRepository.DeleteProductById(productId))
                return true;
            return false;
        }

        public string GetProductById(int productId, out double productPrice)
        {
            if (ProductRepository.GetProductById(productId, out Product product))
            {
                productPrice = product.ProductPrice;
                return $"Product Id: {product.ProductId}, name: {product.ProductName}, price: {product.ProductPrice}";
            }
            productPrice = 0;
            return string.Empty;
        }
    }
}
