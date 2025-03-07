using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment4._2
{
    public class Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        public Time()
        {
            
            Hour = 0;
            Minute = 0;
        }

        public Time(int hour, int minute)
        {
            SetTime(hour, minute);
        }
        public void  SetTime(int hour , int minute)
        {
            if (hour < 0 || hour > 23) throw new Exception("小时数不合法");
            if (minute < 0 || minute > 59) throw new Exception("分钟数不合法");
            this.Hour = hour;
            this.Minute = minute;
        }
        public bool Equals(Time t)
        {
            return t.Hour == Hour && t.Minute == Minute;
        }
    }
}
