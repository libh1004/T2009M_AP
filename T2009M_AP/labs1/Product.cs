using System;
using System.Collections.Generic;
namespace T2009M_AP.session1
{
    public class Product
    {
        public int id;
        public string name;
        public decimal price;
        public int qty;
        public int image;
        public int desc;
        public List<string> gallery = new List<string>();

        public Product()
        {
        }

        public Product(int id, string name, decimal price, int qty, int image, int desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
        }

        public void GetInfo()
        {
            Console.WriteLine("Ma san pham: "+id);
            Console.WriteLine("Ten san pham: "+name);
            Console.WriteLine("Gia san pham: "+price);
            Console.WriteLine("So luong san pham: "+qty);
            Console.WriteLine("Anh san pham: "+image);
            Console.WriteLine("Do giam dan cua san pham: "+desc);
        }

        public bool CheckPro(int qty)
        {
            if (qty > 0) return true;
            return false;
        }

        public void AddImage(string imageNew2, int index)
        {
            if (image < 10)
            {
                gallery.Add(imageNew2);
                Console.WriteLine("Them anh thanh cong");
            }
            else
            {
                Console.WriteLine("Danh sach anh truoc khi xoa: ");
                gallery = new List<string>()
                    {"anh1", "anh2", "anh3"};
                foreach (var imageOfGallery in gallery)
                {
                    Console.WriteLine($"{imageOfGallery}");
                }
                gallery.RemoveAt(index);
                Console.WriteLine("Xoa anh thanh cong");
                
                Console.WriteLine("Them anh moi: ");
                imageNew2 = Console.ReadLine();
                gallery.Add(imageNew2);
                Console.WriteLine("Them anh thanh cong");
            }
        }
        public void RemoveImage(int index)
        {
            Console.WriteLine("Danh sach anh truoc khi xoa: ");
            gallery = new List<string>()
                {"anh1", "anh2", "anh3"};
            foreach (var imageOfGallery in gallery)
            {
                Console.WriteLine($"{imageOfGallery}");
            }
            Console.WriteLine("Danh sach sau khi xoa: ");
            gallery.RemoveAt(index);
            
        }
    }
}