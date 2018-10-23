using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class RoadAndMotorwayQuantities
    {
        public List<SimpleMeasurement> TotalPavedArea { get; set; }
        public List<RoadAndMotorwayFunctionalUnits> FunctionalUnits { get; set; }

        public RoadAndMotorwayQuantities()
        {
            TotalPavedArea = new List<SimpleMeasurement>();
            FunctionalUnits = new List<RoadAndMotorwayFunctionalUnits>();
        }
    }
}
