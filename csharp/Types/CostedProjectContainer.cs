using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class CostedProjectContainer
    {
        public string Title { get; set; }
        public List<string> Description { get; set; }
        public CostedProjectContainerChoice Choice { get; set; }
        public List<ConstructionPeriod> ConstructionPeriod { get; set; }
        public List<Milestone> KeyMilestones { get; set; }
        public List<SiteStatus> Site { get; set; }
        public List<Procurement> Procurement { get; set; }
        public List<CostedCategory> CommonCosts { get; set; }
        public List<Building> Building { get; set; }
        public List<RoadAndMotorway> RoadAndMotorway { get; set; }
        public List<Railway> Railway { get; set; }
        public List<Bridge> Bridge { get; set; }
        public List<Tunnel> Tunnel { get; set; }
        public List<Treatment> WasteWaterTreatmentWorks { get; set; }
        public List<Treatment> WaterTreatmentWorks { get; set; }
        public List<Treatment> Treatment { get; set; }
        public List<WellAndBorehole> WellAndBorehole { get; set; }
        public List<PowerGeneratingPlant> PowerGeneratingPlant { get; set; }
        public List<ChemicalPlant> ChemicalPlant { get; set; }
        public List<Refinery> Refinery { get; set; }
        public List<GenericProject> OtherProjectType { get; set; }
        public Enums.KnownProjectDescription ProjectDescription { get; set; }
        public Enums.CostReportStatus CostReportStatus { get; set; }
        public Enums.ReportPriceBasis ReportPriceBasis { get; set; }

        public CostedProjectContainer()
        {
            Description = new  List<string> ();
            ConstructionPeriod = new  List<ConstructionPeriod>();
            KeyMilestones = new  List<Milestone>();
            Site = new  List<SiteStatus>();
            Procurement = new  List<Procurement>();
            CommonCosts = new  List<CostedCategory>();
            Building = new  List<Building>();
            RoadAndMotorway = new  List<RoadAndMotorway>();
            Railway = new  List<Railway>();
            Bridge = new  List<Bridge>();
            Tunnel = new  List<Tunnel>();
            WasteWaterTreatmentWorks = new  List<Treatment>();
            WaterTreatmentWorks = new  List<Treatment>();
            Treatment = new  List<Treatment>();
            WellAndBorehole = new  List<WellAndBorehole>();
            PowerGeneratingPlant = new  List<PowerGeneratingPlant>();
            ChemicalPlant = new  List<ChemicalPlant>();
            Refinery = new  List<Refinery>();
            OtherProjectType = new  List<GenericProject>();

        }
    }
    public class CostedProjectContainerChoice
    {
        public AddressDetails Location { get; set; }
        public LinearCivilEngineeringWorks LinearCivilEngineeringWorks { get; set; }

        public CostedProjectContainerChoice()
        { }
    }
}
