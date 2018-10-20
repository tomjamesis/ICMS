using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Currency
    {
        public String iso4217Code { get; set; }
        public Boolean IsPrimaryCurrency { get; set; }
        public String currencyDescription { get; set; }
        public decimal currencyExchnageRateToPrimary { get; set; }
        public DateTime currencyExchnageRateDate { get; set; }

        public Currency()
        {
            iso4217Code = "GBP";
        }
    }
}
