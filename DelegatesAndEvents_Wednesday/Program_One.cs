using DelegatesAndEvents_Wednesday.First;

namespace DelegatesAndEvents_Wednesday
{
    internal class Program_One
    {
        static async Task Main(string[] args)
        {
            EventSender eventSender = new EventSender();
            EventListener listener = new EventListener();
            eventSender.EventTriggered += listener.HandleEvent;
            await eventSender.StartTimer();
        }
    }
}
