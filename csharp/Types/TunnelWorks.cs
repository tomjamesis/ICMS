using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class TreatmentWorks
    {
        public List<Enums.KnownTreatmentFunction> FunctionalType { get; set; }
        public List<EnvironmentalGrade> EnvironmentalGrade { get; set; }
        public List<TreatmentDesignFeatures> DesignFeatures { get; set; }
        public TreatmentComplexity Complexity { get; set; }
        public SeaLevelHeight HeightAverageHeightToSeaLevel { get; set; }
        public Dimension Dimensions { get; set; }
        public Enums.BuildNature Nature { get; set; }
        public Decimal DesignLifeInYears { get; set; }

        public TreatmentWorks()
        {
            FunctionalType = new List<Enums.KnownTreatmentFunction>();
            EnvironmentalGrade = new List<EnvironmentalGrade>();
            DesignFeatures = new List<TreatmentDesignFeatures>();
        }
    }
}
