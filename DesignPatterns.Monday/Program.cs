namespace DesignPatterns.Monday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ItemRepository itemRepository = new ItemRepository();

            ////First task
            //Item item = new Item(1, "Car");
            //itemRepository.AddItem(item);
            //item = itemRepository.GetItem(1);
            //Console.WriteLine($"{item.Id}: {item.ItemName}");
            //itemRepository.RemoveItem(1);
            //item = itemRepository.GetItem(1);
            //Console.WriteLine($"{item.Id}: {item.ItemName}");

            ////Second task
            //Item item1 = new Item(2, "Yellow car");
            //Item item2 = new Item(3, "Black car");
            //Item item3 = new Item(4, "White car");
            //Item item4 = new Item(5, "Blue airplane");
            //itemRepository.AddItem(item1);
            //itemRepository.AddItem(item2);
            //itemRepository.AddItem(item3);
            //itemRepository.AddItem(item4);
            //var itemList = itemRepository.FindByWord("car");
            //foreach (Item i in itemList)
            //{
            //    Console.WriteLine(i.ItemName);
            //}
            //itemList = itemRepository.FindByWord("scooter");
            //foreach (Item i in itemList)
            //{
            //    Console.WriteLine(i.Id);
            //}

            //Third task
            OrderRepository orderRepository = new OrderRepository();

            var product1 = new ProductItem(1, "Laptop", 22, 800);
            var product2 = new ProductItem(2, "Phone", 444, 300);
            var product3 = new ProductItem(3, "Frige", 12, 1200);
            List<ProductItem> products = new List<ProductItem>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            Order order = new Order(products, 1, "Thomas Shelby");

            orderRepository.AddOrder(order);
            order = orderRepository.GetOrderById(1);
            foreach (var product in order)
                Console.WriteLine(product);
            orderRepository.RemoveOrder(1);
            order = orderRepository.GetOrderById(1);
            foreach (var product in order)
                Console.WriteLine(product);

        }
    }
}
