
namespace DiceSimulation.Logic
{
    public class NumberArgs : EventArgs
    {
        public int Count { get; }
        public int LastNumber { get; }

        public NumberArgs(int count, int lastNumber) 
        {
            Count = count;
            LastNumber = lastNumber;
        }
    }
}
