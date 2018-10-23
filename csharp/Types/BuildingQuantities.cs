using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class BuildingQuantities
    {
        public List<SimpleMeasurement> SiteArea { get; set; }
        public List<SimpleMeasurement> CoveredAreaOnPlan { get; set; }
        public List<SimpleMeasurement> ExternalFloorAreaAsIpms1 { get; set; }
        public List<SimpleMeasurement> InternalFloorAreaAsIpms2 { get; set; }
        public List<IpmsMeasurement> IpmsMeasurement { get; set; }
        public List<BuildingFunctionalUnits> FunctionalUnits { get; set; }

        public BuildingQuantities()
        {
            SiteArea = new List<SimpleMeasurement>();
            CoveredAreaOnPlan = new List<SimpleMeasurement>();
            ExternalFloorAreaAsIpms1 = new List<SimpleMeasurement>();
            InternalFloorAreaAsIpms2 = new List<SimpleMeasurement>();
            IpmsMeasurement = new List<IpmsMeasurement>();
            FunctionalUnits = new List<BuildingFunctionalUnits>();
        }
    }
}
