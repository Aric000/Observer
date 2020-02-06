using System;

namespace ObserverDemo.Demo1
{
    public class StockObserver : IObserver
    {
        private string Name { get; set; }
        private ISubject Subject { get; set; }
        public StockObserver(string name, ISubject subject)
        {
            Name = name;
            Subject = subject;
        }
        public void Update()
        {
            Console.WriteLine("{0},{1}关闭股票行情，继续工作！", Subject.SubjectState, Name);
        }
    }
}
