using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class PowerGeneratingPlantQuantities
    {
        public List<SimpleMeasurement> SiteArea { get; set; }
        public List<CapacityFunctionalUnits> FunctionalUnits { get; set; }

        public PowerGeneratingPlantQuantities()
        {
            SiteArea = new List<SimpleMeasurement>();
            FunctionalUnits = new List<CapacityFunctionalUnits>();                 
        }
    }
}
