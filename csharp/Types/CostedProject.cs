using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class CostedProject : Project
    {
        public CostedProjectCode ProjectCode { get; set; }
        public List<CostedProjectContainer> SubProject { get; set; }
        public List<CostCategory> Costs { get; set; }

        public CostedProject()
        {
            SubProject = new List<CostedProjectContainer>();
            Costs = new List<CostCategory>();
        }
    }
}
