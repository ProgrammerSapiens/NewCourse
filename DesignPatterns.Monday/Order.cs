using System.Collections;

namespace DesignPatterns.Monday
{
    internal class Order : IEnumerable<ProductItem>
    {
        public int OrderId { get; }
        public string Client { get; }
        public double Cost { get; }

        public List<ProductItem> Items;

        public Order(List<ProductItem> items, int orderId, string client)
        {
            Items = items;
            OrderId = orderId;
            Client = client;
            Cost = items.Sum(x => x.Cost);
        }

        public IEnumerator<ProductItem> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
