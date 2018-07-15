using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timerProject
{
    public class timeKeeping
    {
      
        public int CDHour = 0;
        public int CDMin = 0;
        public int CDSec = 0;
        public int CDTotalTime = 0;

        public int SWHour = 0;
        public int SWMin = 0;
        public int SWSec = 0;
        public int SWMiSec = 0;

        public int REHour = 0;
        public int REMin = 0;
        public int RESec = 0;
        public int RETotalTime = 0;





        
        
        public void SWUpdateTime(int currentNum)
        {             
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

        }  

        public void MultUpdateTime(string type, int currentNum, int Hour, int Min, int Sec, int totaltime)
        {
            if (totaltime == 0)
            {
                totaltime = Hour * 3600 + Min * 60 + Sec;
            }

            if (currentNum % 3600 == 0 && Hour > 0)
            {
                Hour--;
                Min += 60;
            }

            if (currentNum % 60 == 0 && Min > 0)
            {
                Min--;
                Sec += 59;

            }

            else if (Sec > 0)
            {
                Sec--;
            }

            switch(type)
            {
                case "countdown":
                    CDHour = Hour;
                    CDMin = Min;
                    CDSec = Sec;
                    CDTotalTime = totaltime;
                    break;

                case "resteye":
                    REHour = Hour;
                    REMin = Min;
                    RESec = Sec;
                    RETotalTime = totaltime;
                    break;
            }
            

        }

        public void setTimeList(string type, string[] data)
        {
            switch(type)
            {
                case "countdown":
                    CDHour = int.Parse(data[0]);
                    CDMin = int.Parse(data[1]);
                    CDSec = int.Parse(data[2]);
                    break;

                case "resteye":
                    REHour = int.Parse(data[0]);
                    REMin = int.Parse(data[1]);
                    RESec = int.Parse(data[2]);
                    break;

            }
           

        }

        public void setTimeInt(string type, string inHour, string inMin, string inSec)
        {
            switch(type)
            {
                case "countdown":
                    CDHour = int.Parse(inHour);
                    CDMin = int.Parse(inMin);
                    CDSec = int.Parse(inSec);
                    break;

                case "resteye":
                    REHour = int.Parse(inHour);
                    REMin = int.Parse(inMin);
                    RESec = int.Parse(inSec);
                    break;              
            }
           
        }
    }
}
