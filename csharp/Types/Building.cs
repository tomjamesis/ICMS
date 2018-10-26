using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Building : CostedProject
    {
        public BuildingWorks Works { get; set; }
        public BuildingQuantities Quantities { get; set; }

        public Building()
        { }
    }
}
