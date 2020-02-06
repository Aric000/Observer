using ObserverDemo.Demo1;
using ObserverDemo.Demo2;
using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Secretray secretray = new Secretray();
            StockObserver stockObserver = new StockObserver("小李", secretray);
            secretray.Attach(stockObserver);
            secretray.SubjectState = "老板回来了";
            secretray.Notify();

            Boss boss = new Boss();
            NbaObserver nbaObserver = new NbaObserver("小王", boss);
            boss.Update += new ObserverDemo.Demo2.EventHandler(nbaObserver.CloseNBATv);
            boss.SubjectState = "我回来了";
            boss.Notify();
            Console.ReadLine();
        }
    }
}
