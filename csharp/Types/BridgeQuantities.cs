using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class BridgeQuantities
    {
        public List<SimpleMeasurement> SurfaceAreaOfDeck { get; set; }
        public List<BridgeFunctionalUnits> FunctionalUnits { get; set; }

        public BridgeQuantities()
        {
            SurfaceAreaOfDeck = new List<SimpleMeasurement>();
            FunctionalUnits = new List<BridgeFunctionalUnits>();
        }
    }
}
