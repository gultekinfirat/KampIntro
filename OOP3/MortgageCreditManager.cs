using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class MortgageCreditManager : ICreditManager// bu sayede her kredi için ayrı ayrı hesaplama metodu yazmak yerine credit manager'daki 
                                                //hesapla metodu ortak kullanılır.
    {
        public void Calculator()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}
