using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDemo.Demo2
{
    public class NbaObserver
    {
        private string Name { get; set; }
        private ISubject2 Subject { get; set; }
        public NbaObserver(string name, ISubject2 subject)
        {
            Name = name;
            Subject = subject;
        }
        public void CloseNBATv()
        {
            Console.WriteLine("{0},{1}关闭NBA电视，继续工作！", Subject.SubjectState, Name);
        }
    }
}
