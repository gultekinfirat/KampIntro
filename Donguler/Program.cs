using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yaılımcı geliştirme kursu";
            string kurs2 = "Programlamaya giriş için temel kurs";
            string kurs3 = "java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            // bu yukarıda yer alan veriler teker teker yazılmak yerine(yukarıda olduğu gibi) diziler aracılığıyla tek bir değişkende tutulacaktır.
            Console.WriteLine("-----------------------------------------------------------");

            // array-Dizi
            // Diziler sayesinde istediğimiz kadar veriyi tek bir değişkende tutabiliriz.

            string[] kurslar = new string[] { "Yaılımcı geliştirme kursu","Programlamaya giriş için temel kurs", "java","python" };

            // Döngüler, birbirine benzeyen işlemleri tekrar etmekte kullanırız.
            for (int i= 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("------------------"+"For döngüsü bitti"+"--------------------------");
            // Bu döngü dizi temelli yapıları tek tek dönmeye yarar.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("-----------------------------------------------------------");







            Console.ReadLine();
        }

    }
}
