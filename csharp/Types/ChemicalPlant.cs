using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class ChemicalPlant : CostedProject
    {
        public ChemicalPlantWorks Works { get; set; }
        public ChemicalPlantQuantities Quantities { get; set; }

        public ChemicalPlant()
        { }
    }
}
