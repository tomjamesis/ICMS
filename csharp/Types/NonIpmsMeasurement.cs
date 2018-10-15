using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class NonIpmsMeasurement
    {
        public decimal MeasurementValue { get; set; }
        //public LimitedUseMeasurementType LimitedUseMeasuredAreaSummary { get; set; }
        //public IncludedMeasurementType IncludedMeasuredAreaSummary { get; set; }
        //public ExcludedMeasurementType ExcludedMeasuredAreaSummary { get; set; }
        public String Standard { get; set; }
        public String MeasurementBasis { get; set; }

        public NonIpmsMeasurement()
        { }
    }
}
