namespace DesignPatterns.Monday
{
    internal interface IItemRepository
    {
        public void AddItem(Item item);
        public Item GetItem(int id);
        public List<Item> FindByWord(string word);
        public void RemoveItem(int id);
    }
}
