using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 50;
            product1.UnitsInStock = 10;

            Product product2 = new Product { ID = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 35, UnitsInStock = 28 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            


        }
    }
}
