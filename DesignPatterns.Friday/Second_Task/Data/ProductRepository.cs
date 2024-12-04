namespace DesignPatterns.Friday.Second_Task.Data
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products;

        public ProductRepository()
        {
            products = new List<Product>();
        }

        public bool AddProduct(int productId, string productName, double productPrice)
        {
            Product product = new Product(productId, productName, productPrice);

            int productIdIndex = products.FindIndex(x => x.ProductId == productId);

            if (productIdIndex == -1)
            {
                products.Add(product);
                return true;
            }
            return false;
        }

        public bool DeleteProductById(int productId)
        {
            int poductIdIndex = products.FindIndex(x => x.ProductId == productId);

            if (poductIdIndex != -1)
            {
                products.RemoveAt(poductIdIndex);
                return true;
            }
            return false;
        }

        public bool GetProductById(int productId, out Product product)
        {
            int poductIdIndex = products.FindIndex(x => x.ProductId == productId);

            if (poductIdIndex != -1)
            {
                product = products[poductIdIndex];
                return true;
            }
            product = new Product();
            return false;
        }
    }
}
