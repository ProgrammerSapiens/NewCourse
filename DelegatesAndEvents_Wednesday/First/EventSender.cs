using System.Diagnostics;

namespace DelegatesAndEvents_Wednesday.First
{
    public delegate void EventTriggeredEventHandler(object sender, EventArgs e);
    internal class EventSender
    {
        public event EventTriggeredEventHandler EventTriggered;
        public Stopwatch stopWatch;

        public EventSender()
        {
            stopWatch = new Stopwatch();
        }

        public async Task StartTimer()
        {
            stopWatch.Start();
            await Task.Delay(10000);
            stopWatch.Stop();

            if (stopWatch.ElapsedMilliseconds > 10000)
                OnEventTriggered();
        }

        protected virtual void OnEventTriggered()
        {
            EventTriggered?.Invoke(this, EventArgs.Empty);
        }
    }
}
