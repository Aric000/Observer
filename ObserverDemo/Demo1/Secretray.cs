using System.Collections.Generic;

namespace ObserverDemo.Demo1
{
    public class Secretray : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        public string SubjectState { get; set; }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }
}
