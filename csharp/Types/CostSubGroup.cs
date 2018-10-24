using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class CostSubGroup : CostedCategory
    {
        public List<Cost> Cost { get; set; }
        public List<Anything> OtherData { get; set; }

        public CostSubGroup()
        {
            Cost = new List<Cost>();
            OtherData = new List<Anything>();
        }
    }
}
