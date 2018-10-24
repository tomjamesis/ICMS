using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class TunnelDesignFeatures
    {
        public SimpleMeasurement averageDepthBelowWaterGround { get; set; }
        public Enums.KnownTunnellingMethod tunnellingMethod { get; set; }
        public Boolean inCompressedAir { get; set; }
        public Enums.TunnelLining lining { get; set; }
        public Enums.Curvature curvature { get; set; }
        public Boolean isUnderwater { get; set; }
        public Boolean isVentilated { get; set; }
        public int noOfPassengersSeparatedByDividingWall { get; set; }

        public TunnelDesignFeatures()
        { }
    }
}
