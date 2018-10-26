using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Pipeline : CostedProject
    {
        public PipelineWorks Works { get; set; }
        public PipelineQuantities Quantities { get; set; }

        public Pipeline()
        { }
    }
}
