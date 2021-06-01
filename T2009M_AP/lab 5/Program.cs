using System;
using System.Threading;

namespace T2009M_AP.lab_5
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            ShowTime st = new ShowTime();
            Thread t1 = new Thread(st.CalculateTime);
            t1.Start();
        }
    }
}