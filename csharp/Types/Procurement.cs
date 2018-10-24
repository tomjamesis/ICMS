using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Procurement
    {
        public Enums.Funding funding { get; set; }
        public Enums.KnownPricingMethod pricingMethod { get; set; }
        public Enums.KnownModeOfProcurement modeOfProcurement { get; set; }
        public Boolean jointVentureForeignConstructor { get; set; }
        public Enums.LocalForeign predominantSourceOfConstructors { get; set; }

        public Procurement()
        { }
    }
}
