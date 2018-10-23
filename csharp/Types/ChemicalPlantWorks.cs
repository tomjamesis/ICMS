using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class ChemicalPlantWorks
    {
        public EnvironmentalGrade EnvironmentalGrade { get; set; }
        public ChemicalPlantDesignFeatures DesignFeatures { get; set; }
        public ChemicalPlantComplexity Complexity { get; set; }
        public SeaLevelHeight AverageHeightToSeaLevel { get; set; }
        public Dimension Dimensions { get; set; }
        public Enums.ChemicalPlantFunctional ChemicalPlantFunction { get; set; }
        public Enums.BuildNature ChemicalPlantNature { get; set; }
        public decimal designLifeInYears { get; set; }

        public ChemicalPlantWorks()
        { }
    }
}
