using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class RangedMeasurement
    {
        public decimal Minimum { get; set; }
        public decimal Maximum { get; set; }
        public UnitOfMeasurement unitOfMeasurement { get; set; }

        public RangedMeasurement()
        { }
    }
}
