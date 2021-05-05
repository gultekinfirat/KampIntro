using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type safety- Tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogreniciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Yükselis Butonu");
            }
            else
            {
                Console.WriteLine("Esitlik Butonu");
            }


            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


            Console.ReadLine();

        }
    }
}
