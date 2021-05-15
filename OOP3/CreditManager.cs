using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface ICreditManager//Bu koda göre eğer herhangi bir yerde 'CreditManager' kullanılırsa o kullanımda söz konusu metot kullanılmak zorundadır.
        // Ayrıca okunurluğu arttırmak adına interface isimlerinin başına 'I' gelir.Interface; şablon, arayüz anlamına gelir.
        // İnterface'i birbirinin alternatifi olan ancak kod içeriği farklı olan durumlar için kullanırız.(ÖNEMLİ)
    {
        void Calculator();
        // Birden fazla metot yazılabilir.

    } 
}
