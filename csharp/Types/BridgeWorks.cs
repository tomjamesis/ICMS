using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class BridgeWorks
    {
        public List<Enums.KnownBridgeTunnelFunction> FunctionalType { get; set; }
        public List<EnvironmentalGrade> EnvironmentalGrade { get; set; }
        public List<BridgeDesignFeatures> DesignFeatures { get; set; }
        public BridgeComplexity Complexity { get; set; }
        public SeaLevelHeight AverageDeckHeightToSeaLevel { get; set; }
        public SimpleMeasurement Width { get; set; }
        public SeaLevelHeight MinimumHeightToSeaLevel { get; set; }
        public SeaLevelHeight MaximumHeightToSeaLevel { get; set; }

        public Enums.BuildNature Nature { get; set; }
        public Decimal DesignLifeInYears { get; set; }

        public BridgeWorks()
        {
            FunctionalType = new List<Enums.KnownBridgeTunnelFunction>();
            EnvironmentalGrade = new List<EnvironmentalGrade>();
            DesignFeatures = new List<BridgeDesignFeatures>();
        }
    }
}
