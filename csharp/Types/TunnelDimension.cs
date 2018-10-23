using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class TunnelDimension
    {
        public CrossSection crossSection { get; set; }
        public Overall overall { get; set; }
        public SimpleMeasurement Length { get; set; }

        public enum CrossSection
        {
            SimpleMearsurement,
            RangedMeasurement
        }
        public enum Overall
        {
            Dimension,
            DimensionAsRange
        }

        public TunnelDimension()
        { }
    }
}
