using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class BridgeDesignFeatures
    {
        public BridgeSpan Span { get; set; }
        public List<Enums.KnownMaterial> unboundedMaterials { get; set; }
        public List<Enums.KnownBridgeObstacleCrossed> unboundedObstacleCrossed { get; set; }
        public Enums.KnownBridgeSupport support { get; set; }
        public Enums.BridgeMobility mobility { get; set; }

        public BridgeDesignFeatures()
        {
            unboundedMaterials = new List<Enums.KnownMaterial>();
            unboundedObstacleCrossed = new List<Enums.KnownBridgeObstacleCrossed>();
        }
    }
}
