using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class PowerGeneratingPlantDesignFeatures
    {
        public List<Turbine> Turbine { get; set; }
        public Enums.KnownMaterial generatorContainmentMaterial { get; set; }
        public Enums.KnownPowerGeneratingPlantCoolant coolant { get; set; }
        public Enums.OpenClose cycle { get; set; }


        public PowerGeneratingPlantDesignFeatures()
        {
            Turbine = new List<Turbine>();
        }
    }
}
