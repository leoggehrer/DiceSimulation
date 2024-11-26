namespace DiceSimulation.Logic
{
    /// <summary>
    /// Represents an observer that receives notifications from an observable object.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Notifies the observer that the observable object has changed.
        /// </summary>
        /// <param name="sender">The object that sent the notification.</param>
        /// <param name="e">The event arguments.</param>
        void Notify(object sender, EventArgs e);
    }
}
