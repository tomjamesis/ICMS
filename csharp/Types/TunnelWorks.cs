using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class TunnelWorks
    {
        public List<Enums.KnownBridgeTunnelFunction> FunctionalType { get; set; }
        public List<EnvironmentalGrade> EnvironmentalGrade { get; set; }
        public List<TunnelDesignFeatures> DesignFeatures { get; set; }
        public TunnelComplexity Complexity { get; set; }
        public SeaLevelHeight HeightAverageHeightToSeaLevel { get; set; }
        public Dimension Dimensions { get; set; }
        public Enums.BuildNature Nature { get; set; }
        public Decimal DesignLifeInYears { get; set; }

        public TunnelWorks()
        {
            FunctionalType = new List<Enums.KnownBridgeTunnelFunction>();
            EnvironmentalGrade = new List<EnvironmentalGrade>();
            DesignFeatures = new List<TunnelDesignFeatures>();
        }
    }
}
