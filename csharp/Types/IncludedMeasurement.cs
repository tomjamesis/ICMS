using System;
using System.Collections.Generic;

namespace csharp.Types
{
    public class IncludedMeasurement
    {
        public decimal MeasurementValue { get; set; }
        public List<AlternativeMeasurement> AlternativeMeasurement { get; set; }
        public SeparateAreaCategory IncludedAreaCategory { get; set; }
        public String Description { get; set; }
        
        public IncludedMeasurement()
        {
            AlternativeMeasurement = new List<AlternativeMeasurement>();
        }
    }
}
