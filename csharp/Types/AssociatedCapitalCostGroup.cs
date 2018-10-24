using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class AssociatedCapitalCostGroup
    {
        public List<CostSubGroup> WorkAndUtilitiesOffsite { get; set; }
        public List<CostSubGroup> PostCompletionLooseFurnitureFittingsAndEquipment { get; set; }
        public List<CostSubGroup> ConstructionRelatedConsultantsAndSupervision { get; set; }
        public List<CostSubGroup> RiskAllowances { get; set; }

        public AssociatedCapitalCostGroup()
        {
            WorkAndUtilitiesOffsite = new List<CostSubGroup>();
            PostCompletionLooseFurnitureFittingsAndEquipment = new List<CostSubGroup>();
            ConstructionRelatedConsultantsAndSupervision = new List<CostSubGroup>();
            RiskAllowances = new List<CostSubGroup>();
        }
    }
}
