using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    //声明参数类型
    public class ClockEventArgs : EventArgs
    {
    }
    //声明委托类型
    public delegate void ClockEventHandler(object sender,ClockEventArgs e);
    //定义事件源
    public class Clock
    {
        //声明事件
        public event ClockEventHandler AlarmClock;
        public void DoClock(int nHour,int nMinute)
        {
            //判断设定时间是否与当前时间相同
            while(DateTime.Now.Hour != nHour || DateTime.Now.Minute != nMinute)
            {
            }
            //时间相同，发生事件，通知外界
            ClockEventArgs args = new ClockEventArgs();
            AlarmClock(this, args);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请设置您的时:");
            string s = Console.ReadLine();
            int nHour = int.Parse(s);
            Console.Write("请设置您的分:");
            s = Console.ReadLine();
            int nMinute = int.Parse(s);
            var clock = new Clock();
            clock.AlarmClock += ShowProgress;//注册事件
            clock.DoClock(nHour,nMinute);
        }
        //事件处理方法
        static void ShowProgress(object sender,ClockEventArgs e)
        {
            Console.WriteLine("嗨，到时间啦。");
        }
    }
}
