using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class RefineryWorks
    {
        public EnvironmentalGrade EnvironmentalGrade { get; set; }
        public RefineryDesignFeatures DesignFeatures { get; set; }
        public RefineryComplexity Complexity { get; set; }
        public SeaLevelHeight AverageHeightToSeaLevel { get; set; }
        public Dimension Dimensions { get; set; }
        public Enums.KnownRefineryFunction RefineryFunction { get; set; }
        public Enums.BuildNature RefineryNature { get; set; }
        public Enums.BuildGrade RefineryGrade { get; set; }
        public decimal designLifeInYears { get; set; }

        public RefineryWorks()
        { }
    }
}
