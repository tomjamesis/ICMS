using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Railway : CostedProject
    {
        public RailwayWorks Works { get; set; }
        public RailwayQuantities Quantities { get; set; }

        public Railway()
        { }
    }
}
