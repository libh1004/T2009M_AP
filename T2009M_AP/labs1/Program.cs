using System;

namespace T2009M_AP.session1
{
     public class Program
    {
        
         public static void Main(string[] args)
         {
             Product p = new Product();
             Product p2 = new Product(1, "sp1", 12000, 4, "anh23", 2);
            
            p2.GetInfo();
            Console.WriteLine("-------------------------");
            Console.WriteLine(p2.CheckPro());
            Console.WriteLine("-------------------------");
           
            p2.AddImage("anh3",1);
            Console.WriteLine("---------------------------");
            p2.RemoveImage(1);
            foreach (string image in p2.gallery)
            {
                Console.WriteLine($"{image}");
            }
            
        /*    Fashion f = new Fashion("red","M");
            Console.WriteLine( f.CheckColorSize());

            Diamon d = new Diamon(4);
            d.CheckRealFake();*/
        }
    }
}