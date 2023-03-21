using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Program
    {
        static Clock clock = new Clock();

        static void Main(string[] args)
        {
            Console.WriteLine(Clock.current.ToString());
            clock.SetClock(Clock.current.Hour,Clock.current.Minute,(Clock.current.Second+30)%60);
            for (int count = 1; count <=60; count++)
            {
                //注册事件
                clock.Tick +=TickTake;
                clock.Alarm +=AlarmTake;
                clock.ClockRun();
                clock.DoEvent();
                //注销事件
                clock.Tick -= TickTake;
                clock.Alarm -= AlarmTake;
            }
        }
        static void TickTake(object sender,TickEventArgs e)
        {
            Console.WriteLine(e.Tick_str);
            clock.GetNowTime();
        }
        static void AlarmTake(object sender,AlarmEventArgs e)
        {
            Console.WriteLine(e.Alarm_str);
        }
    }
}
