using System;

namespace T2009M_AP.lab4
{
    public class ExDelegate
    {
        public static void ShowInfo(int num1, int num2)
        {
            Console.WriteLine("num1: "+num1);
            Console.WriteLine("num2: "+num2);
        }
        public void AddNumber(int num1, int num2)
        {
            Console.WriteLine("Tong 2 so: "+(num1 + num2));
        }
        public void SubNumber(int num1, int num2)
        {
            Console.WriteLine("Hieu 2 so: "+(num1 - num2));
        }
        public void MulNumber(int num1, int num2)
        {
            Console.WriteLine("Tich 2 so: "+(num1 * num2));
        }
        public void DivNumber(int num1, int num2)
        {
            Console.WriteLine("Thuong 2 so: "+(num1 / num2));
        }
    }
}