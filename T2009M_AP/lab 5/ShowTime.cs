using System;
using System.Linq;
using System.Security.AccessControl;
using System.Threading;
namespace T2009M_AP.lab_5
{
    public class ShowTime
    {
        public int min = 10;
        public int sec = 0;

        public void CalculateTime()
        {
            while (min >= 0)
            {
                while (sec >= 0)
                {
                    
                    if (min >= 10 && sec >= 10)
                    {
                        Console.WriteLine(min+" : "+sec);
                    }
                    else if(min < 10 && sec >= 10)
                    {
                        Console.WriteLine("0"+min.ToString()+" : "+sec);
                    }else if (min >= 10 && sec < 10)
                    {
                        Console.WriteLine(min+" : "+"0"+sec.ToString());
                    }
                    else
                    {
                        Console.WriteLine("0"+min.ToString()+" : "+"0"+sec.ToString());
                    }
                    sec--;
                    try
                    {
                        Thread.Sleep(100);
                    }
                    catch (Exception e)
                    {
                    }
                }
                
                if (sec < 0) {
                    sec = 59;
                }
                min--;
                
            }Console.WriteLine("Bùm");
            
        }
    }
}