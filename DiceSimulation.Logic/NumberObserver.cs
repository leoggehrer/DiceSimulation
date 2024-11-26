namespace DiceSimulation.Logic
{
    public class NumberObserver : IObserver
    {
        public int Count { get; private set; }
        public int WatchCount { get; private set; }
        public int WatchNumber { get; private set; }

        public NumberObserver(int watchNumber)
        {
            WatchNumber = watchNumber;
        }
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

        public override string ToString()
        {
            return $"Number of litters {Count, 5}, number of hits {WatchCount}, number {WatchNumber} with Hit probability {(double)WatchCount/Count:f3}";
        }
    }
}
