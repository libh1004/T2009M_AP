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

        public void CheckPro()
        {
            if (qty > 0)
            {
                Console.WriteLine("Con hang");
            }
            else
            {
                Console.WriteLine("Het hang");
            }
        }

        public void AddImage()
        {
            if (image < 10)
            {
                Console.WriteLine("Nhap anh can them: ");
                string numToAdd = Console.ReadLine();
                gallery.Add(numToAdd);
                Console.WriteLine("Them anh thanh cong");
            }
            else
            {
                Console.WriteLine("Danh sach truoc khi xoa:  ");
                gallery = new List<string>() {"anh1", "anh2", "anh3"};
                foreach (var imageOfGallery in gallery)
                {
                    Console.WriteLine($"{imageOfGallery} ");
                }
                Console.WriteLine("Nhap vi tri anh can xoa: ");
                int posToRemove2 = Convert.ToInt32(Console.ReadLine());
                gallery.RemoveAt(posToRemove2);
                Console.WriteLine("Xoa anh thanh cong");
                
                Console.WriteLine("Them anh moi: ");
                string imageNew = Console.ReadLine();
                gallery.Add(imageNew);
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