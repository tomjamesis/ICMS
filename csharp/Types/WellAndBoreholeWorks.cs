using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class WellAndBoreholeWorks
    {
        public List<EnvironmentalGrade> EnvironmentalGrade { get; set; }
        public WellAndBoreholeDesignFeatures DesignFeatures { get; set; }
        public WellAndBoreholeComplexity Complexity { get; set; }
        public SeaLevelHeight MinimumHeightToSeaLevel { get; set; }
        public SeaLevelHeight MaximumHeightToSeaLevel { get; set; }
        public Dimension AverageCorridorWidthBetweenLegalBoundaries { get; set; }
        public SimpleMeasurement TrackGauge { get; set; }
        public Enums.KnownWellAndBoreholeFunction WellAndBoreholeFunction { get; set; }
        public Enums.BuildNature Nature { get; set; }
        public Decimal DesignLifeInYears { get; set; }
        public int noOfPipes { get; set; }

        public WellAndBoreholeWorks()
        {
            EnvironmentalGrade = new List<EnvironmentalGrade>();
        }
    }
}
