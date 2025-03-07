using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment4._2
{
    
    class Clock
    {
        public Clock(int hour , int minute)
        {
            time = new Time(hour, minute);
        }
        private Time time;
        public delegate void CallHandler(object sender, EventArgs args);
        public event CallHandler OnCall;
        public void SetTime(int hour ,int minute)
        {
            time.SetTime(hour, minute);
        }
        public void  AddAppointedTime(int hour ,int minute)
        {
            Time t = new Time(hour, minute);
            AppointedTime.Add(t);
        }
        public void Run()
        {
            Console.Write($"现在时刻，北京时间{time.Hour}:{time.Minute}  ");
            EventArgs args = new EventArgs(time);
            OnCall(this,args);
            time.Minute++;
            if(time.Minute > 59)
            {
                time.Minute = time.Minute % 60;
                time.Hour++;
                if(time.Hour > 23)
                {
                    time.Hour = time.Hour % 24;
                }
            }
        }
        
        private List<Time> AppointedTime = new List<Time>();
        public void ForEach(Action<Time> action)
        {
            foreach (var t in AppointedTime)
                action(t);
        }
        public Time GetTime() { return this.time; }
    }
}
