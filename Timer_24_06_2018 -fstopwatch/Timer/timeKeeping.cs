using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timerProject
{
    public class timeKeeping
    {
      
        public int countDownHour = 0;
        public int countDownMin = 0;
        public int countDownSec = 0;
        public int countDownTotalTime = 0;

        public int SWHour = 0;
        public int SWMin = 0;
        public int SWSec = 0;
        public int SWMiSec = 0;



        
        
        public void updateTime(string type, int currentNum)
        {
           

            switch(type)
            {
                case "countdown":

                    if (countDownTotalTime == 0)
                    {
                        countDownTotalTime = countDownHour * 3600 + countDownMin * 60 + countDownSec;
                        //Console.WriteLine(countDownTotalTime);
                    }

                    if (currentNum % 3600 == 0 && countDownHour > 0)
                    {
                        countDownHour--;
                        countDownMin += 60;
                    }

                    if (currentNum % 60 == 0 && countDownMin > 0)
                    {
                        countDownMin--;
                        countDownSec += 59;

                    }

                    else if (countDownSec > 0)
                    {
                        countDownSec--;
                    }
                    break;



                case "stopwatch":
                    
                    if (SWMiSec < 100)
                    {
                        SWMiSec++;
                    }

                    if (currentNum% 100 == 0 && currentNum > 0 )
                    {
                        SWMiSec = 0;
                        SWSec ++;
;
                    }

                    if(currentNum % 6000 == 0 && currentNum > 0)
                    {
                        SWSec = 0;
                        SWMin++;

                    }

                    if (currentNum % 360000 == 0 && currentNum > 0)
                    {
                        SWMin = 0;
                        SWHour++;

                    }
                    break;
            }


           



        }  

        public void setTimeList(string type, List<string> data)
        {
            switch(type)
            {
                case "countdown":
                    countDownHour = int.Parse(data[0]);
                    countDownMin = int.Parse(data[1]);
                    countDownSec = int.Parse(data[2]);
                    break;
            }
           

        }

        public void setTimeInt(string type, string inHour, string inMin, string inSec)
        {
            switch(type)
            {
                case "countdown":
                    countDownHour = int.Parse(inHour);
                    countDownMin = int.Parse(inMin);
                    countDownSec = int.Parse(inSec);
                    break;

               
            }
           
        }
    }
}
