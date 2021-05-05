using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();// Class tanımlama kodu. Bir sınıfa veri girişi yapılmadan önce o sınıf tanıtılmalıdır.
            product1.Id = 1;
            product1.ProductName = "Elma";
            product1.Price = 5.7;
            product1.Explanation = "Amasya Elması";

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Karpuz";
            product2.Price = 14;
            product2.Explanation = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1,product2 };// Ürünler diziye aktarıldı.
            foreach (Product product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("----------------------------------------------------");
            }

            Console.WriteLine("------------------------Methods---------------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);




            Console.ReadLine();

        }
    }
}
