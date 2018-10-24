using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class RefineryDesignFeatures
    {
        public List<Enums.RefineryProcess> PrincipalProcesses { get; set; }
        public List<Enums.KnownReactorMaterial> PrincipalReactorMaterial { get; set; }

        public RefineryDesignFeatures()
        {
            PrincipalProcesses = new List<Enums.RefineryProcess>();
            PrincipalReactorMaterial = new List<Enums.KnownReactorMaterial>();
        }
    }
}
