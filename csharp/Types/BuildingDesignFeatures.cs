using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class BuildingDesignFeatures
    {
        public Enums.KnownBuildingStructure structure { get; set; }
        public Enums.KnownWallDesign externalWall { get; set; }
        public Enums.EnvironmentalControl environmentalControl { get; set; }
        public Enums.PrefabricationDegree prefabricationDegree { get; set; }

        public BuildingDesignFeatures()
        { }
    }
}
