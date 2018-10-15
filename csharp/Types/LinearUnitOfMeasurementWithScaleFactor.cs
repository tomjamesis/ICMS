using System;

namespace csharp.Types
{
    public class LinearUnitOfMeasurementWithScaleFactor
    {
        public decimal ScaleFactor { get; set; }
        public Boolean IsPriIsPrimaryUnitMeasurement { get; set; }
        public String MeasurementDescription { get; set; }

        public LinearUnitOfMeasurementWithScaleFactor()
        { }
    }
}
