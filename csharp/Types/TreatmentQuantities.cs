using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class TreatmentQuantities
    {
        public List<SimpleMeasurement> SiteArea { get; set; }
        public List<TreatmentFunctionalUnits> FunctionalUnits { get; set; }

        public TreatmentQuantities()
        {
            SiteArea = new List<SimpleMeasurement>();
            FunctionalUnits = new List<TreatmentFunctionalUnits>();
        }
    }
}
