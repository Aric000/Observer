using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDemo.Demo2
{
    public interface ISubject2
    {
        void Notify();
        string SubjectState { get; set; }
    }
}
