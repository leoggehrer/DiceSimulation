namespace DiceSimulation.ConApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dice Simulation");

        Logic.Dice dice = new Logic.Dice();
        Logic.NumberObserver[] observers = new Logic.NumberObserver[6];

        for (int i = 0; i < observers.Length; i++)
        {
            observers[i] = new Logic.NumberObserver(i + 1);
            dice.AddObserver(observers[i]);
        }

        for (int i = 0; i < 100_000; i++)
        {
            dice.Roll();
        }

        Console.WriteLine();
        Console.WriteLine("Statistics:");
        Console.WriteLine();

        for (int i = 0; i < observers.Length; i++)
        {
            Console.WriteLine(observers[i].ToString());
        }

        dice.RemoveAll();

    }
}
