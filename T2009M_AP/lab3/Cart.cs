using System;
using T2009M_AP.session1;
using System.Collections.Generic;
namespace T2009M_AP.lab3
{
    public class Cart
    {
        private int id;
        private string customer;
        private decimal grandTotal;
        public List<Product> productList = new List<Product>();
        private string city;
        private string country;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Customer
        {
            get => customer;
            set => customer = value;
        }

        public decimal GrandTotal
        {
            get => grandTotal;
            set => grandTotal = value;
        }

        public List<Product> ProductList
        {
            get => productList;
            set => productList = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public Product this[int index]
        {
            get => productList[index];
            set => productList[index] = value; 
        }
     
        public void AddProduct(Product product)
        {
            if (product.CheckPro())
            {
                productList.Add(product);
                product.Qty --;
                GrandTotal += product.Price;
                Console.WriteLine("Them thanh cong");
            }
            else
            {
                Console.WriteLine("Them that bai");
            }
        }

        public void RemoveProduct(Product product, int index)
        {
            
            productList.RemoveAt(index);
            product.Qty++;
            GrandTotal -= product.Price;
            Console.WriteLine("Xoa thanh cong");
            
        }

        public decimal CalGrandTotal()
        {
             if (city == "Ha Noi" || city == "HCM") {
                return GrandTotal + GrandTotal * 1/100;
            }else if(city != "Ha Noi" || city != "HCM") {
                return GrandTotal + GrandTotal * 2/100;
            }
             else if(country != "Viet Nam")
             {
                 return GrandTotal + GrandTotal * 5/100;
             }

             return GrandTotal;
        }
       
    }
}