using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class RefineryQuantities
    {
        public List<SimpleMeasurement> SiteArea { get; set; }
        public List<RefineryFunctionalUnits> FunctionalUnits { get; set; }

        public RefineryQuantities()
        {
            SiteArea = new List<SimpleMeasurement>();
            FunctionalUnits = new List<RefineryFunctionalUnits>();
        }
    }
}
