using System.Collections;

namespace DesignPatterns.Monday
{
    internal class ProductItem : IEnumerable<ProductItem>
    {
        public int ProductId { get; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public double Cost { get; set; }
        public ProductItem(int id, string description, int amount, double cost)
        {
            ProductId = id;
            Description = description;
            Amount = amount;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"ID: {ProductId}, Description: {Description}, Amount: {Amount}, Cost: {Cost}";
        }

        public IEnumerator<ProductItem> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
