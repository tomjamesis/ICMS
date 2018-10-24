using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class NonIpmsMeasurement
    {
        public decimal MeasurementValue { get; set; }
        public List<LimitedUseMeasurement> LimitedUseMeasuredAreaSummary { get; set; }
        public List<IncludedMeasurement> IncludedMeasuredAreaSummary { get; set; }
        public List<ExcludedMeasurement> ExcludedMeasuredAreaSummary { get; set; }
        public String Standard { get; set; }
        public String MeasurementBasis { get; set; }

        public NonIpmsMeasurement()
        {
            LimitedUseMeasuredAreaSummary = new List<LimitedUseMeasurement>();
            IncludedMeasuredAreaSummary = new List<IncludedMeasurement>();
            ExcludedMeasuredAreaSummary = new List<ExcludedMeasurement>();
        }
    }
}
