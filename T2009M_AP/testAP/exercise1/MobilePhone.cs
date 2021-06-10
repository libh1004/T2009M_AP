using System;
using T2009M_AP.session1;

namespace T2009M_AP.testAP.exercise1
{
    public class MobilePhone : Phone
    {
        public MobilePhone(string phoneName, string phoneType, float phonePrice) : base(phoneName, phoneType, phonePrice)
        {
        }

        public void Display()
        {
            Console.WriteLine("Phone: "+phoneName+", type "+phoneType+", price "+phonePrice);

        }
    }
}