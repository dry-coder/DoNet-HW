using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    //声明参数类型
    public class TickEventArgs : EventArgs
    {
        public string Tick_str;
    }
    public class AlarmEventArgs : EventArgs
    {
        public string Alarm_str;
    }
    //声明委托类型
    public delegate void TickEventHandler(object sender, TickEventArgs e);
    public delegate void AlarmEventHandler(object sender, AlarmEventArgs e);
    //定义事件源
    public class Clock
    {
       public static DateTime current = DateTime.Now;
        //声明事件
        public event TickEventHandler Tick;
        public event AlarmEventHandler Alarm;
        //闹钟的基本成员变量
        int now_h, now_m, now_s;//当前时间
        int h, m, s;//闹钟
        public Clock()
        {
            now_h = current.Hour;
            now_m = current.Minute;
            now_s = current.Second;
        }
        public void SetClock(int h,int m,int s)
        {
            this.h = h;
            this.m = m;
            this.s = s;
        }
        public void ClockRun()
        {
            System.Threading.Thread.Sleep(1000);
            if (now_s  == 59)
            {
                now_s = 0;
                if (now_m  ==59)
                {
                    now_m = 0;
                    if(now_h== 23)
                    {
                        now_h = 0;
                    }
                    else
                    {
                        now_h++;
                    }
                }
                else
                {
                    now_m ++;
                }
            }
            else
            {
                now_s++;
            }
        }
        public void GetNowTime()
        {
            Console.WriteLine($"{now_h} : {now_m} : {now_s}");
        }
        public void DoEvent()
        {
            TickEventArgs Tick_Args = new TickEventArgs();
            Tick_Args.Tick_str = "时钟发生滴答";
            Tick(this, Tick_Args);

            if (now_h == h && now_m == m && now_s == s)
            {
                AlarmEventArgs Alarm_Args = new AlarmEventArgs();
                Alarm_Args.Alarm_str = "闹钟响了";
                Alarm(this, Alarm_Args);
            }
        }
    }
}
