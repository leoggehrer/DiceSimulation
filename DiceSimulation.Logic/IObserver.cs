namespace DiceSimulation.Logic
{
    public interface IObserver
    {
        void Notify(object sender, EventArgs e);
    }
}
