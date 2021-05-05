using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class FourOperations
    {
        public void Addition(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplama işlemi sonucu: " + sonuc);
        }
        public void Extraction(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Çıkarma işlemi sonucu: " + sonuc);
        }
        public void Multiplication(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Çarpma işlemi sonucu: " + sonuc);
        }
        public void Division(double sayi1, double sayi2)
        {
            double sonuc = sayi1 / sayi2;
            Console.WriteLine("Bölme işlemi sonucu: " + sonuc);
        }
        
        

    }


}
