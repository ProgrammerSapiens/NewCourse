namespace DelegatesAndEvents_Friday
{
    public delegate void StateChangedHandler(string message);
    internal class StateNotifier
    {
        public event StateChangedHandler StateChanged;
        public bool State { get; private set; }

        public StateNotifier()
        {
            State = false;
        }

        public void ChangeState()
        {
            if (!State)
            {
                State = true;
                OnStateChanged("State is true now");
            }
            else
            {
                State = false;
                OnStateChanged("State is false now");
            }
        }
        protected virtual void OnStateChanged(string message)
        {
            StateChanged?.Invoke(message);
        }
    }
}
