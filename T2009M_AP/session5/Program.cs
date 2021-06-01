using System;
using System.Threading;

namespace T2009M_AP.session5
{
   /*  public class Program
    {
       
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(Run20Times); // truyen vao function se chay khi start thread, voi static function
            t1.Start("xin chao"); // truyen tham so cho ham

            Thread t2 = new Thread(new Program().Show20Times); // voi non-static function
            t2.Start();

            Thread t3 = new Thread(delegate() // anonymous function
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("Anonymous function ..."+i);
                    try
                    {
                        Thread.Sleep(1000);
                    }
                    catch (Exception e)
                    {
                    
                    }
                }

            });
            t3.Start();

            session4.Caculate c1 = delegate(int a, int b) { return a * a + b * b }; // c1 la 1 function
            Console.WriteLine("5 bp + 4 bp = "+c1(5,4));

            session4.Caculate c2 = (a, b) => a * a + b * b; // c2 cung la 1 function // lambda expression trong java - arrow function trong js
            Console.WriteLine("5 bp + 4 bp = "+c2(5,4));
            c1 += c2; //ghep c2 vao c1;
            c1 += c2 += c2 += c1;
            /*
             *c2 = c2+c2;
             *  c2 = c2 + c2;
             * c1 = c1  +c2;
             */
            
            // async await // xu ly bat dong bo
  /*         
        }

        public static void Run20Times(object obj) // neu co tham so thi duoc 1 tham so Object
        {
            string msg = obj as string; // ep kieu (cast)
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(msg+" ..."+i);
                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    
                }
            }
        }

        public void Show20Times()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Running ..."+i);
                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    
                }
            }
        }
    }*/
}