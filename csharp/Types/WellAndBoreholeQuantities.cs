using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class WellAndBoreholeQuantities
    {
        public List<SimpleMeasurement> LengthOfDrilledBoredDepth { get; set; }
        public List<CapacityFunctionalUnits> FunctionalUnits { get; set; }

        public WellAndBoreholeQuantities()
        {
            LengthOfDrilledBoredDepth = new List<SimpleMeasurement>();
            FunctionalUnits = new List<CapacityFunctionalUnits>();
        }
    }
}
