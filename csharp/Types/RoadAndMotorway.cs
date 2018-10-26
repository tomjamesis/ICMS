using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class RoadAndMotorway : CostedProject
    {
        public RoadAndMotorwayWorks Works { get; set; }
        public RoadAndMotorwayQuantities Quantities { get; set; }

        public RoadAndMotorway()
        { }
    }
}
