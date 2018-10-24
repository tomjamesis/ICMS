using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class RoadAndMotorwayDesignFeatures
    {
        public SimpleMeasurement DesignSpeed { get; set; }
        public SimpleMeasurement LaneWidth { get; set; }
        public SimpleMeasurement FootwayWidth { get; set; }
        public Enums.RoadAndMotorwayPosition position { get; set; }
        public int noOfCarriageways { get; set; }
        public int noOfLanesPerCarriageway { get; set; }
        public Boolean hardShoulders { get; set; }
        public Boolean hasFootways { get; set; }
        public Enums.RoadAndMotorwaySurface surfacing { get; set; }
        public Enums.RoadAndMotorwayVerticalProfile verticleProfile { get; set; }
        public Enums.RoadAndMotorwayPlanProfile planProfile { get; set; }

        public RoadAndMotorwayDesignFeatures()
        { }
    }
}
