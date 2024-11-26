namespace DiceSimulation.Logic
{
    public abstract class Observable
    {
        #region fields
        private List<IObserver> _observers = new();
        #endregion fields

        public void RemoveAll()
        {
            lock (this)
            {
                _observers.Clear();
            }
        }
        public void AddObserver(IObserver observer)
        {
            lock(this)
            {
                if (_observers.Contains(observer) == false)
                {
                    _observers.Add(observer);
                }
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            lock (this)
            {
                _observers.Remove(observer);
            }
        }

        protected void NotifyObservers(EventArgs e)
        {
            lock(this)
            {
                foreach (var observer in _observers)
                {
                    Task.Run(() => observer.Notify(this, e));
                }
            }
        }
    }
}
