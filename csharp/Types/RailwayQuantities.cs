using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class RailwayQuantities
    {
        public List<SimpleMeasurement> RouteLength { get; set; }
        public List<SimpleMeasurement> EquatedTrackLength { get; set; }
        public List<RailwayFunctionalUnits> FunctionalUnits { get; set; }

        public RailwayQuantities()
        {
            RouteLength = new List<SimpleMeasurement>();
            EquatedTrackLength = new List<SimpleMeasurement>();
            FunctionalUnits = new List<RailwayFunctionalUnits>();
        }
    }
}
