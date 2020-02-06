using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDemo.Demo2
{
    public delegate void EventHandler();
    public class Boss : ISubject2
    {
        //声明一事件Update,类型为委托EventHandler
        public event EventHandler Update;
        public string SubjectState { get; set; }

        /// <summary>
        /// 在访问“通知”时调用“更新”
        /// </summary>
        public void Notify()
        {
            Update();
        }
    }
}
