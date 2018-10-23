using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class PipelineWorks
    {
        public List<EnvironmentalGrade> EnvironmentalGrade { get; set; }
        public PipelineDesignFeatures DesignFeatures { get; set; }
        public PipelineComplexity Complexity { get; set; }
        public SeaLevelHeight MinimumHeightToSeaLevel { get; set; }
        public SeaLevelHeight MaximumHeightToSeaLevel { get; set; }
        public Dimension AverageCorridorWidthBetweenLegalBoundaries { get; set; }
        public SimpleMeasurement TrackGauge { get; set; }
        public Enums.PipelineFunction PipelineFunction { get; set; }
        public Enums.BuildNature Nature { get; set; }
        public Decimal DesignLifeInYears { get; set; }
        public int noOfPipes { get; set; }

        public PipelineWorks()
        {
            EnvironmentalGrade = new List<EnvironmentalGrade>();
        }
    }
}
