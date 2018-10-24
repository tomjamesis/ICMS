using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class StoreyInformation
    {
        public StoreyHeightMeasurement StoreyHeight { get; set; }
        public SimpleMeasurement TypicalStoreyHeight { get; set; }
        public int StoreyCountAboveGround { get; set; }
        public int StoreyCountBelowGround { get; set; }
        public Enums.StoreyQualitativeDescription description { get; set; }

        public StoreyInformation()
        { }
    }
}
