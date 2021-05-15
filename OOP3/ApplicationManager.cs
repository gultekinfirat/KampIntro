using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager
    {
        public void MakeAnApplication(ICreditManager creditManager, ILoggerService loggerService)
        
            //prametre olarak kredi türü sorulur ve ona göre işlem yapılır.
            // ICredit manager diğer tüm kredilerin referansını zaten tuttuğundan dolayı kendisini kullanarak diğer kredilere de ulaşırız.
        {
            creditManager.Calculator();
            loggerService.Log();

        }

        public void CreditPreNotification(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculator();
            }
        }
    }
}
