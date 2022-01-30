using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        //void ile int'nin farkı, örneğin bu iki örnekte Topla() metoduna int verdiğimiz zaman diğer sayfada çıkan sonucu bir
        //fonksiyona atayıp tekrardan kullanabiliyoruz.Ancak void ile bu işlemi yapamıyoruz.Sadece bir defa kullanabiliyoruz void ile.
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
