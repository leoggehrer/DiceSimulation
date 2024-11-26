namespace DiceSimulation.Logic
{
    public class Dice : Observable
    {
        private static readonly Random random = new Random(DateTime.UtcNow.Millisecond);
        public int Count { get; private set; }
        public int LastNumber { get; private set; }

        public void Reset()
        {
            Count = 0;
            LastNumber = 0;
        }
        public void Roll()
        {
            Count++;
            LastNumber = random.Next(1, 7);
            NotifyObservers(new NumberArgs(Count, LastNumber));
        }
    }
}
