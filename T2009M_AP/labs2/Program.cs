using System;

namespace T2009M_AP.session1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product(1,"anh1",12000,90,10,9);
           
                     
             Fashion f = new Fashion("red","M");
            Console.WriteLine( f.CheckColorSize());
    
            Diamon d = new Diamon(4);
            d.CheckRealFake();
        }
       
    }
}