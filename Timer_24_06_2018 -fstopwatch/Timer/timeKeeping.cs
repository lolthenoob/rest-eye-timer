using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timerProject
{
    public class timeKeeping
    {
      
        public int hour = 0;
        public int min = 0;
        public int sec = 0;
        public int totalTime = 0;
        
        
        public void updateTime(int type)
        {
            if(totalTime == 0)
            {
                totalTime = hour * 3600 + min * 60 + sec;
                //Console.WriteLine(totalTime);
            }

            if (type % 3600 == 0 && hour > 0)
            {
                hour--;
                min += 59;
            }

            if (type % 60 == 0 && min > 0)
            {
                min--;
                sec += 59;

            }

            else if (sec > 0)
            {
                sec--;
            }



        }  

        public void setTimeList(List<string> data)
        {
            hour = int.Parse(data[0]);
            min = int.Parse(data[1]);
            sec = int.Parse(data[2]);

        }

        public void setTimeInt(string inHour, string inMin, string inSec)
        {
            hour = int.Parse(inHour);
            min = int.Parse(inMin);
            sec = int.Parse(inSec);
        }
    }
}
