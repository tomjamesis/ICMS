using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class CapitalConstructionCostGroup : CostedCategory
    {
        public List<CostSubGroup> DemolitionSitePreparationAndFormation { get; set; }
        public List<CostSubGroup> Substructure { get; set; }
        public List<CostSubGroup> Structure { get; set; }
        public List<CostSubGroup> ArchitecturalWorks_NonStructuralWorks { get; set; }
        public List<CostSubGroup> ServicesAndEquipment { get; set; }
        public List<CostSubGroup> SurfaceAndUndergroundDrainage { get; set; }
        public List<CostSubGroup> ExternalAndAncillaryWorks { get; set; }
        public List<CostSubGroup> PreliminariesConstructors_SiteOverheads_GeneralRequirements { get; set; }
        public List<CostSubGroup> RiskAllowances { get; set; }
        public List<CostSubGroup> TaxesAndLevies { get; set; }

        public CapitalConstructionCostGroup()
        {
            DemolitionSitePreparationAndFormation = new List<CostSubGroup>();
            Substructure = new List<CostSubGroup>();
            Structure = new List<CostSubGroup>();
            ArchitecturalWorks_NonStructuralWorks = new List<CostSubGroup>();
            ServicesAndEquipment = new List<CostSubGroup>();
            SurfaceAndUndergroundDrainage = new List<CostSubGroup>();
            ExternalAndAncillaryWorks = new List<CostSubGroup>();
            PreliminariesConstructors_SiteOverheads_GeneralRequirements = new List<CostSubGroup>();
            RiskAllowances = new List<CostSubGroup>();
            TaxesAndLevies = new List<CostSubGroup>();
        }
    }
}
