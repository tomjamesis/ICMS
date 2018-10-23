using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class TunnelQuantities
    {
        public List<SimpleMeasurement> VolumeOfExcavation { get; set; }
        public List<Enums.BridgeTunnelFunctionalUnits> FunctionalUnits { get; set; }

        public TunnelQuantities()
        {
            VolumeOfExcavation = new List<SimpleMeasurement>();
            FunctionalUnits = new List<Enums.BridgeTunnelFunctionalUnits>();
        }
    }
}
