using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class TreatmentWorks
    {
        public List<EnvironmentalGrade> EnvironmentalGrade { get; set; }
        public List<TreatmentDesignFeatures> DesignFeatures { get; set; }
        public TreatmentComplexity Complexity { get; set; }
        public SeaLevelHeight MinimumHeightToSeaLevel { get; set; }
        public SeaLevelHeight MaximumHeightToSeaLevel { get; set; }
        public Dimension Dinemsions { get; set; }
        public TreatmentFunction TreatmentFunction { get; set; }
        public Enums.BuildNature Nature { get; set; }
        public Decimal DesignLifeInYears { get; set; }
        public int noOfPipes { get; set; }

        public TreatmentWorks()
        {
            EnvironmentalGrade = new List<EnvironmentalGrade>();
            DesignFeatures = new List<TreatmentDesignFeatures>();
        }
    }
}
