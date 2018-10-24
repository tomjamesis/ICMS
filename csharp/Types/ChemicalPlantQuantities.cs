using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class ChemicalPlantQuantities
    {
        public List<SimpleMeasurement> SiteArea { get; set; }
        public List<ChemicalPlantFunctionalUnits> FunctionalUnits { get; set; }

        public ChemicalPlantQuantities()
        {
            SiteArea = new List<SimpleMeasurement>();
            FunctionalUnits = new List<ChemicalPlantFunctionalUnits>();
        }
    }
}
