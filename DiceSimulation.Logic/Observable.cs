namespace DiceSimulation.Logic
{
    /// <summary>
    /// Represents an abstract class that can be observed by implementing the observer pattern.
    /// </summary>
    public abstract class Observable
    {
        #region fields
        private List<IObserver> _observers = new();
        #endregion fields

        /// <summary>
        /// Removes all observers from the list.
        /// </summary>
        public void RemoveAll()
        {
            lock (this)
            {
                _observers.Clear();
            }
        }

        /// <summary>
        /// Adds an observer to the list if it is not already present.
        /// </summary>
        /// <param name="observer">The observer to add.</param>
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

        /// <summary>
        /// Removes an observer from the list.
        /// </summary>
        /// <param name="observer">The observer to remove.</param>
        public void RemoveObserver(IObserver observer)
        {
            lock (this)
            {
                _observers.Remove(observer);
            }
        }

        /// <summary>
        /// Notifies all observers of an event.
        /// </summary>
        /// <param name="e">The event arguments to pass to the observers.</param>
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

