using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class PowerGeneratingPlantWorks
    {
        public EnvironmentalGrade EnvironmentalGrade { get; set; }
        public PowerGeneratingPlantDesignFeatures DesignFeatures { get; set; }
        public PowerGeneratingPlantComplexity Complexity { get; set; }
        public SeaLevelHeight AverageHeightToSeaLevel { get; set; }
        public Dimension Dimensions { get; set; }
        public Enums.KnownPowerGeneratingPlantFunction PowerGeneratingPlantFunction { get; set; }
        public Enums.BuildNature PowerGeneratingPlantNature { get; set; }
        public decimal designLifeInYears { get; set; }

        public PowerGeneratingPlantWorks()
        { }
    }
}
