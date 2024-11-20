namespace DelegatesAndEvents_Wednesday.First
{
    internal class EventListener
    {
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Событие произошло");
        }
    }
}
