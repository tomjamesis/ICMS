using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class CostedCategory
    {
        public List<Decimal> CostSummary { get; set; }

        public CostedCategory()
        {
            CostSummary = new List<decimal>();
        }
    }
}
