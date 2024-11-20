namespace DelegatesAndEvents_Wednesday.Second
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductEventArgs : EventArgs
    {
        public Product Product { get; }
        public ProductEventArgs(Product product)
        {
            Product = product;
        }
    }

    internal class ProductManager
    {
        private List<Product> products = new List<Product>();
        public event EventHandler<ProductEventArgs> ProductAdded;
        public event EventHandler<ProductEventArgs> ProductUpdated;
        public event EventHandler<ProductEventArgs> ProductRemoved;

        public void AddProduct(Product product)
        {
            products.Add(product);
            OnProductAdded(new ProductEventArgs(product));
        }

        public void UpdateProduct(string productName, Product updatedProduct)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.Price = updatedProduct.Price;
                OnProductUpdated(new ProductEventArgs(product));
            }
        }

        public void RemoveProduct(string productName)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                products.Remove(product);
                OnProductRemoved(new ProductEventArgs(product));
            }
        }

        protected virtual void OnProductAdded(ProductEventArgs e)
        {
            ProductAdded?.Invoke(this, e);
        }

        protected virtual void OnProductUpdated(ProductEventArgs e)
        {
            ProductUpdated?.Invoke(this, e);
        }

        protected virtual void OnProductRemoved(ProductEventArgs e)
        {
            ProductRemoved?.Invoke(this, e);
        }
    }

    public class NotificationService
    {
        public void HandleProductAdded(object sender, ProductEventArgs e)
        {
            Console.WriteLine($"Новый продукт добавлен: {e.Product.Name} за {e.Product.Price}.");
        }

        public void HandleProductUpdated(object sender, ProductEventArgs e)
        {
            Console.WriteLine($"Продукт обновлен: {e.Product.Name}.");
        }

        public void HandleProductRemoved(object sender, ProductEventArgs e)
        {
            Console.WriteLine($"Продукт удален: {e.Product.Name}.");
        }
    }
}
