using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {//ProductName'nin özelliklerini böyle de sıralayabiliriz.İkinci yolla da yapabiliriz.İkinci yol daha pratik.
            Product product1 = new Product();
            product1.Id = 1;
            product1.UnitInStock = 3;
            product1.UnitPrice = 500;
            product1.ProductName = "Masa";
            product1.CategoryId = 2;

        //Bu şekilde de property'leri yazabiliriz ve bu yukardakinden daha pratik.
            Product productName2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem",
                UnitPrice = 35, UnitInStock = 5};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Topla2(8,5);//Bunu void ile yazdırdık ve ikinci bir işlem yapamıyoruz.

            int toplamaSonucu = productManager.Topla(6, 9);
            Console.WriteLine(toplamaSonucu*34);//Bunu int ile yazdırığımız için ikinci bir işlem yapabiliyoruz.Tabi fonksiyona atıyarak.


                        
        }
    }
}
