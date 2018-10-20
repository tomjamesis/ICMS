using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class BuildingWorks
    {
        public EnvironmentalGrade EnvironmentalGrade { get; set; }
        public BuildingDesignFeatures DesignFeatures { get; set; }
        public BuildingComplexity Complexity { get; set; }
        public SeaLevelHeight AverageHeightToSeaLevel { get; set; }
        public Dimension Dimensions { get; set; }
        public StoreyInformation StoreyInformation { get; set; }
        public Enums.KnownBuildingFunction BuildingFunction { get; set; }
        public Enums.BuildNature BuildingNature { get; set; }
        public Enums.BuildGrade BuildingGrade { get; set; }
        public decimal designLifeInYears { get; set; }

        public BuildingWorks()
        { }
    }
}
