using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class TunnelComplexity
    {
        public int noOfIntersections { get; set; }
        public Enums.HorizontalProfile horizontalProfile { get; set; }
        public Enums.KnownCrossSectionalShape crossSectionalShape { get; set; }

        public TunnelComplexity()
        { }
    }
}
