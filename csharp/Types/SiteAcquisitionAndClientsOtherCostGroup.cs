using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class SiteAcquisitionAndClientsOtherCostGroup
    {
        public List<CostSubGroup> SiteAcquisition { get; set; }
        public List<CostSubGroup> AdministrativeFinanceLegalAndMarketingExpenses { get; set; }

        public SiteAcquisitionAndClientsOtherCostGroup()
        {
            SiteAcquisition = new List<CostSubGroup>();
            AdministrativeFinanceLegalAndMarketingExpenses = new List<CostSubGroup>();
        }
    }
}
