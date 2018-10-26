using System;

namespace csharp.Types
{
    public class ExcludedMeasurement
    {
        public decimal MeasurementValue { get; set; }
        public AlternativeMeasurement AlternativeMeasurement { get; set; }
        public SeparateAreaCategory ExcludedAreaCategory { get; set; }
        public String Description { get; set; }

        public ExcludedMeasurement()
        { }
    }
}
