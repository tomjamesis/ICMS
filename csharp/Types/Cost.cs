using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Cost
    {
        public List<String> Description { get; set; }
        public decimal Value { get; set; }
        public Enum.KnownCostCode costCode { get; set; }
        public Enum.CostCodes costSubCode { get; set; }
        public Boolean isCivilEngineeringWorks { get; set; }
        public Boolean isExcluded { get; set; }
        public object Any { get; set; }

        public Cost()
        {
            isCivilEngineeringWorks = false;
            isExcluded = false;
        }
    }
}
