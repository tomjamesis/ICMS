
using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class IpmsMeasurement
    {
        public decimal MeasurementValue { get; set; }
        public List<LimitedUseMeasurement> LimitedUseMeasuredAreaSummary { get; set; }
        public List<IncludedMeasurement> IncludedMeasuredAreaSummary { get; set; }
        public List<ExcludedMeasurement> ExcludedMeasuredAreaSummary { get; set; }

        public IpmsMeasurement()
        {
            LimitedUseMeasuredAreaSummary = new List<LimitedUseMeasurement>();
            IncludedMeasuredAreaSummary = new List<IncludedMeasurement>();
            ExcludedMeasuredAreaSummary = new List<ExcludedMeasurement>();
        }
    }
}
