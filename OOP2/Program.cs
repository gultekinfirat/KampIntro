using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // SOLID
            // Engin Demiroğ
            Indıvidual customer1 = new Indıvidual(){Id=1, TcNo="12345678910", CustomerNo="12345", FirstName="Engin", LastName="Demiroğ" };

            // Kodlama.io
            Coorporate customer2 = new Coorporate(){Id=2,CustomerNo="54321",CompanyName="Kodlama.io",TaxNumber="1234567890" };

            Customer customer3 = new Indıvidual();//Bu iki koddaki kritik nokta Customer sınıfının,                                       
            Customer customer4 = new Coorporate(); //diğer 2 alt müşteri sınıfının da referansını tutabiliyor olması


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            


        }
    }
}
