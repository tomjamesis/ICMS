using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class PowerGeneratingPlant : CostedProject
    {
        public PowerGeneratingPlantWorks Works { get; set; }
        public PowerGeneratingPlantQuantities Quantities { get; set; }

        public PowerGeneratingPlant()
        { }
    }
}
