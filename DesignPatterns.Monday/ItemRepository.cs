
namespace DesignPatterns.Monday
{
    internal class ItemRepository : IItemRepository
    {
        private List<Item> Items;

        public ItemRepository()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            int index = Items.FindIndex(x => x.Id == item.Id);

            if (index == -1)
            {
                Items.Add(item);
                Console.WriteLine("The element was added successfully");
            }
            else Console.WriteLine("Such ID already exists");
        }

        public Item GetItem(int id)
        {
            Item? item = Items.Find(x => x.Id == id);

            if (item == null)
            {
                return new Item(0, "The element was not found");
            }

            return item;
        }

        public List<Item> FindByWord(string word)
        {
            List<Item> items = Items.Where(x => x.ItemName.ToLower().Contains(word)).ToList();

            if (items.Count == 0)
            {
                Console.WriteLine("There is no elements with this word");
                return new List<Item>(0);
            }
            return items;
        }

        public void RemoveItem(int id)
        {
            int index = Items.FindIndex(x => x.Id == id);

            if (index != -1)
            {
                Items.RemoveAt(index);
                Console.WriteLine("The element was removed successfully");
            }
            else Console.WriteLine("The element was not found");
        }
    }
}
