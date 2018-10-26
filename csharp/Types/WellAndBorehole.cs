using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class WellAndBorehole : CostedProject
    {
        public WellAndBoreholeWorks Works { get; set; }
        public WellAndBoreholeQuantities Quantities { get; set; }

        public WellAndBorehole()
        { }
    }
}
