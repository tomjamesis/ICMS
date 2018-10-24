using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class RailwayWorks
    {
        public List<EnvironmentalGrade> EnvironmentalGrade { get; set; }
        public List<RailwayDesignFeatures> DesignFeatures { get; set; }
        public RailwayComplexity Complexity { get; set; }
        public SeaLevelHeight MinimumHeightToSeaLevel { get; set; }
        public SeaLevelHeight MaximumHeightToSeaLevel { get; set; }
        public Dimension AverageCorridorWidthBetweenLegalBoundaries { get; set; }
        public SimpleMeasurement TrackGauge { get; set; }
        public Enums.RailwayFunctional RailwayFunction { get; set; }
        public Enums.BuildNature Nature { get; set; }
        public Decimal DesignLifeInYears { get; set; }
        public Enums.KnownTrainPowerSystem trainPowerSystems { get; set; }
        public Enums.RailwayConstructionRigidity constructionRigidity { get; set; }
        public Enums.RailwayRailJoints railJoints { get; set; }
        public Enums.KnownRailwayControlSystem controlSystems { get; set; }
        public Enums.RailwaySignallingSystem signallingSystem { get; set; }

        public RailwayWorks()
        {
            EnvironmentalGrade = new List<EnvironmentalGrade>();
            DesignFeatures = new List<RailwayDesignFeatures>();
        }
    }
}
