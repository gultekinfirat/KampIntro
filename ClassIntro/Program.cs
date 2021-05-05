using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();// classlar bu şekilde tanımlanır.Kurs'u bir değişken gibi düşün aslında biz class sayesinde bir deişken tanımladık.
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi+": "+kurs1.Egitmen);
            // Kurslar classına tanımlanan elemanlar bir diziye aktarılarak bu işlem dinamik hale getirilebilir.Böylece teker teker listelemek yerine döngü ile tek seferde listelenir.

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + "  " + kurs.Egitmen + "  " + kurs.IzlenmeOrani);
            }


            Console.ReadLine();
        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }


        }
    }
    
}
