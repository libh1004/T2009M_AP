using System;

namespace T2009M_AP.session1
{
    public class Diamon : Product
    {
        public float carat;

        public Diamon(float carat)
        {
            this.carat = carat;
        }

        public void CheckRealFake()
        {
            if (carat > 1.7)
            {
                Console.WriteLine("Hang gia");
            }
            else
            {
                Console.WriteLine("Hang that");
            }
           
        }
    }
}