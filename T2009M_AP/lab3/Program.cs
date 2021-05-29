using System;
using System.Xml.Serialization;
using T2009M_AP.session1;

namespace T2009M_AP.lab3
{

    public class Program
    {
      
        public static void Main(string[] args)
        {
            Product p1 = new Product(1,"san pham 1",2000,4,"anh3",5);
            Product p2 = new Product(2,"san pham 2",5000,5,"anh34",3);
            Product p3 = new Product(3,"san pham 3",4000,3,"anh3",5);
            Product p4 = new Product(4,"san pham 4",8000,4,"anh6",5);
            
            
            Cart c = new Cart();
            c.Id = 1;
            c.Customer = "Nguyen Van A";
            c.City = "Ninh Thuan";
            c.Country = "Viet Nam";
            
            
            c.AddProduct(p1);
            c.AddProduct(p1);
            c.AddProduct(p1);
            

        }
        
    }
}