
namespace DiceSimulation.Logic
{
    /// <summary>
    /// Represents the event arguments for a number event.
    /// </summary>
    public class NumberArgs : EventArgs
    {
        /// <summary>
        /// Gets the count of numbers.
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// Gets the last number generated.
        /// </summary>
        public int LastNumber { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberArgs"/> class.
        /// </summary>
        /// <param name="count">The count of numbers.</param>
        /// <param name="lastNumber">The last number generated.</param>
        public NumberArgs(int count, int lastNumber) 
        {
            Count = count;
            LastNumber = lastNumber;
        }
    }
}
