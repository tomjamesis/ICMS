using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class PipelineQuantities
    {
        public List<SimpleMeasurement> LengthOfPipes { get; set; }
        public List<SimpleMeasurement> LengthFromServicingInletsToOutlets { get; set; }
        public List<CapacityFunctionalUnits> FunctionalUnits { get; set; }


        public PipelineQuantities()
        {
            LengthOfPipes = new List<SimpleMeasurement>();
            LengthFromServicingInletsToOutlets = new List<SimpleMeasurement>();
            FunctionalUnits = new List<CapacityFunctionalUnits>();
        }
    }
}
