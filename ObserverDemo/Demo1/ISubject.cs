using System;
using System.Text;

namespace ObserverDemo.Demo1
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
        string SubjectState { get; set; }
    }
}
