namespace DesignPatterns.Monday
{
    internal class Item
    {
        public int Id { get; }
        public string ItemName { get; set; }

        public Item(int id, string itemName)
        {
            Id = id;
            ItemName = itemName;
        }
    }
}
