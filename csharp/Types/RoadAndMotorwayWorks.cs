using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class RoadAndMotorwayWorks : CostedProject
    {
        public List<EnvironmentalGrade> EnvironmentalGrade { get; set; }
        public List<RoadAndMotorwayDesignFeatures> DesignFeatures { get; set; }
        public RoadAndMotorwayComplexity Complexity { get; set; }
        public SeaLevelHeight MinimumHeightToSeaLevel { get; set; }
        public SeaLevelHeight MaximumHeightToSeaLevel { get; set; }
        public Dimension RoadDimensions { get; set; }
        public Enums.RoadAndMotorwayFunction RoadAndMotorwayFunction { get; set; }
        public Enums.BuildNature Nature { get; set; }
        public Decimal DesignLifeInYears { get; set; }

        public RoadAndMotorwayWorks()
        {
            EnvironmentalGrade = new List<EnvironmentalGrade>();
            DesignFeatures = new List<RoadAndMotorwayDesignFeatures>();
        }
    }
}
