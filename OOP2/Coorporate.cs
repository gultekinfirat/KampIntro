using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Coorporate:Customer// Bu olay sayesinde 'müşteride olan özellikler artık burada da vardır' demiş olduk.
    {
       
        public string CompanyName { get; set; }

        public string TaxNumber { get; set; }

    }
}
