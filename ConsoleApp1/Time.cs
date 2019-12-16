using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Time
    {
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }

        static public bool operator ==(Time lhs, Time rhs)
        {
            if (lhs.Hours == rhs.Hours && Math.Abs(lhs.Minutes - rhs.Minutes) < 15)
            {
                return true;
            }
            else if (Math.Abs(lhs.Hours * 60 + lhs.Minutes - (rhs.Hours * 60 + rhs.Minutes)) < 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public  bool operator !=(Time lhs, Time rhs)
        {
            if (lhs.Hours == rhs.Hours && Math.Abs(lhs.Minutes - rhs.Minutes) >= 15)
            {
                return false;
            }
            else if (Math.Abs(lhs.Hours * 60 + lhs.Minutes - (rhs.Hours * 60 + rhs.Minutes)) >= 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
