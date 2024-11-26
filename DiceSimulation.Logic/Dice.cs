namespace DiceSimulation.Logic
{
    /// <summary>
    /// Represents a dice that can be rolled to generate random numbers between 1 and 6.
    /// Inherits from the Observable class to notify observers of roll events.
    /// </summary>
    public class Dice : Observable
    {
        private static readonly Random random = new Random(DateTime.UtcNow.Millisecond);

        /// <summary>
        /// Gets the total count of rolls.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Gets the last number rolled.
        /// </summary>
        public int LastNumber { get; private set; }

        /// <summary>
        /// Resets the dice roll count and last number.
        /// </summary>
        public void Reset()
        {
            Count = 0;
            LastNumber = 0;
        }

        /// <summary>
        /// Rolls the dice to generate a random number between 1 and 6.
        /// Notifies observers of the roll event.
        /// </summary>
        public void Roll()
        {
            Count++;
            LastNumber = random.Next(1, 7);
            NotifyObservers(new NumberArgs(Count, LastNumber));
        }
    }
}