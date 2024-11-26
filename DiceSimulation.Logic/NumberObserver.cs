namespace DiceSimulation.Logic
{
    /// <summary>
    /// Observes number events and tracks the count of a specific number.
    /// </summary>
    public class NumberObserver : IObserver
    {
        /// <summary>
        /// Gets the total count of number events observed.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Gets the count of events where the watched number was observed.
        /// </summary>
        public int WatchCount { get; private set; }

        /// <summary>
        /// Gets the number being watched.
        /// </summary>
        public int WatchNumber { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberObserver"/> class with the specified number to watch.
        /// </summary>
        /// <param name="watchNumber">The number to watch for in the events.</param>
        public NumberObserver(int watchNumber)
        {
            WatchNumber = watchNumber;
        }

        /// <summary>
        /// Notifies the observer of an event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        public void Notify(object sender, EventArgs e)
        {
            if (e is NumberArgs numberArgs)
            {
                Count = numberArgs.Count;
                if (numberArgs.LastNumber == WatchNumber)
                {
                    WatchCount++;
                }
            }
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"Number of litters {Count, 5}, number of hits {WatchCount}, number {WatchNumber} with Hit probability {(double)WatchCount/Count:f3}";
        }
    }
}