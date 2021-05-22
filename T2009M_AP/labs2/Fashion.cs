using System;

namespace T2009M_AP.session1
{
    public class Fashion : Product
    {
        public string color;
        public string size;
        
        public Fashion(string color, string size)
        {
            this.color = color;
            this.size = size;
        }

        public bool CheckColorSize()
        {
           if (CheckPro(10))
           {
                if (color == "green" && size == "M")
                {
                    return true;
                }
           }
           return false;
        }
    }
}