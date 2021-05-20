using System;
namespace T2009M_AP.session1
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product(1,"anh1",12000,56,3,9);
            
            
            p2.GetInfo();
            p2.CheckPro();
           
            p2.AddImage();
            p2.RemoveImage(1);
            foreach (string images in p2.gallery)
            {
                Console.WriteLine($"{images}");
            }
        }
    }
}