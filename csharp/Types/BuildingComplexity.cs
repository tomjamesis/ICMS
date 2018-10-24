using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class BuildingComplexity
    {
        public Enums.Shape shapeOnPlan { get; set; }
        public Enums.DesignComplexity design { get; set; }
        public Enums.KnownWorkingMethod methodOfWorking { get; set; }

        public BuildingComplexity()
        { }
    }
}
