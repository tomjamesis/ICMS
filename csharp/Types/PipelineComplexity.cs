using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class PipelineComplexity
    {
        public Enums.LandUnderwater position { get; set; }
        public int noOfIntersections { get; set; }
        public int noOfSpecials { get; set; }
        public int noOfCrossingsOverRoadsRailwaysWaterwaysValleys { get; set; }
        public int noOfPumpingStationsInspectionPressureReliefPoints { get; set; }

        public PipelineComplexity()
        { }
    }
}
