using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class PipelineDesignFeatures
    {
        public SimpleMeasurement MinimumDepthBelowGround { get; set; }
        public SimpleMeasurement MaximumDepthBelowGround { get; set; }
        public SimpleMeasurement MinimumHeightAboveGround { get; set; }
        public SimpleMeasurement MaximumHeightAboveGround { get; set; }
        public Enums.KnownPipelineMaterial principalMaterials { get; set; }
        public Enums.PipelineDrillingBoringMethod drillingBoringMethod { get; set; }
        public string insulationType { get; set; }

        public PipelineDesignFeatures()
        { }
    }
}
