using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class ConstructionPeriod
    {
        public List<int> Duration { get; set; }
        public List<ConstructionDate> DateFrom { get; set; }
        public List<ConstructionDateToState> DateTo { get; set; }

        public ConstructionPeriod()
        {
            Duration = new List<int>();
            DateFrom = new List<ConstructionDate>();
            DateTo = new List<ConstructionDateToState>();
        }
    }
}
