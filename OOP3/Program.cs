using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
           // MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            //mortgageCreditManager.Calculator();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
           
            //PersonalFinanceCreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager.Calculator();
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
           
            //TransportCreditManager transportCreditManager = new TransportCreditManager();
            //transportCreditManager.Calculator();
            ICreditManager transportCreditManager = new TransportCreditManager();

            ILoggerService fileloggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(personalFinanceCreditManager,new DatabaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager,transportCreditManager };
            //applicationManager.CreditPreNotification(credits);






            Console.ReadLine();
        }
    }
}
