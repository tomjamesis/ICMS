using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class CostCategory
    {
        public List<CapitalConstructionCostGroup> CapitalConstructionCosts { get; set; }
        public List<AssociatedCapitalCostGroup> AssociatedCapitalCosts { get; set; }
        public List<SiteAcquisitionAndClientsOtherCostGroup> SiteAcquisitionAndClientsOtherCosts { get; set; }


        public CostCategory()
        {
            CapitalConstructionCosts = new List<CapitalConstructionCostGroup>();
            AssociatedCapitalCosts = new List<AssociatedCapitalCostGroup>();
            SiteAcquisitionAndClientsOtherCosts = new List<SiteAcquisitionAndClientsOtherCostGroup>();
        }
    }
}