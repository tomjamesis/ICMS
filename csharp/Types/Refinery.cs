using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Refinery : CostedProject
    {
        public RefineryWorks Works { get; set; }
        public RefineryQuantities Quantities { get; set; }

        public Refinery()
        { }
    }
}
