using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Bridge : CostedProject
    {
        public BridgeWorks Works { get; set; }
        public BridgeQuantities Quantities { get; set; }

        public Bridge()
        { }
    }
}
