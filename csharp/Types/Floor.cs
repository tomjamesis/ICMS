using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Floor
    {
        public List<String> Description { get; set; }
        //public List<FloorPlan> FloorPlans { get; set; }
        //public List<ComponentContainer> MeasuredComponents { get; set; }
        public List<LinearMeasurement> InternalHeight { get; set; }
        public List<LinearMeasurement> ClearHeight { get; set; }
        //public List<Ipms1Measurement> Ipms1MeasuredFloorArea { get; set; }
        //public List<Ipms2Measurement> Ipms2MeasuredFloorArea { get; set; }
        public List<Ipms3Measurement> Ipms3MeasuredFloorArea { get; set; }
        public List<IpmsMeasurement> NonIpmsMeasuredArea { get; set; }
        public String id { get; set; }
        public BuildingUse BuildingUse { get; set; }
        //public Reference Reference { get; set; }
        public String Label { get; set; }
        public List<object> Attributes { get; set; }

        public Floor()
        {
            Description = new List<String>();
            //FloorPlans = new List<FloorPlan>();
            //MeasuredComponents = new List<ComponentContainer>();
            InternalHeight = new List<LinearMeasurement>();
            ClearHeight = new List<LinearMeasurement>();
            //Ipms1MeasuredFloorArea = new List<Ipms1Measurement>();
            //Ipms2MeasuredFloorArea = new List<Ipms2Measurement>();
            Ipms3MeasuredFloorArea = new List<Ipms3Measurement>();
            Attributes = new List<object>();
        }
    }
}
