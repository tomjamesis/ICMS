using System;

namespace csharp.Types
{
    public class VolumeUnitOfMeasurementWithScaleFactor : UnitOfMeasurement
    {
        public Decimal scaleFactor { get; set; }
        public Boolean isPrimaryUnitMeasurement { get; set; }
        public String measurementDescription { get; set; }

        public VolumeUnitOfMeasurementWithScaleFactor()
        { }
    }
}
