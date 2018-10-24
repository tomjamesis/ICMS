using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class ChemicalPlantDesignFeatures
    {
        public List<Enums.KnownChemicalPlantProcess> PrincipalProcesses { get; set; }
        public List<Enums.KnownReactorMaterial> PrincipalReactorMaterial { get; set; }

        public ChemicalPlantDesignFeatures()
        {
            PrincipalProcesses = new List<Enums.KnownChemicalPlantProcess>();
            PrincipalReactorMaterial = new List<Enums.KnownReactorMaterial>();
        }
    }
}
