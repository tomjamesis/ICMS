using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Floor
    {
        public List<String> Description { get; set; }
        public List<FloorPlan> FloorPlans { get; set; }
        public List<ComponentContainer> MeasuredComponents { get; set; }
        public List<LinearMeasurement> InternalHeight { get; set; }
        public List<LinearMeasurement> ClearHeight { get; set; }
        public List<IpmsMeasurement> Ipms1MeasuredFloorArea { get; set; }
        public List<IpmsMeasurement> Ipms2MeasuredFloorArea { get; set; }
        public List<Ipms3Measurement> Ipms3MeasuredFloorArea { get; set; }
        public List<NonIpmsMeasurement> NonIpmsMeasuredArea { get; set; }
        public String id { get; set; }
        public RoadAndMotorwayUse primaryUse { get; set; }
        public String reference { get; set; }
        public String Label { get; set; }
        public List<object> Attributes { get; set; }

        public Floor()
        {
            Description = new List<String>();
            FloorPlans = new List<FloorPlan>();
            MeasuredComponents = new List<ComponentContainer>();
            InternalHeight = new List<LinearMeasurement>();
            ClearHeight = new List<LinearMeasurement>();
            Ipms1MeasuredFloorArea = new List<IpmsMeasurement>();
            Ipms2MeasuredFloorArea = new List<IpmsMeasurement>();
            Ipms3MeasuredFloorArea = new List<Ipms3Measurement>();
            NonIpmsMeasuredArea = new List<NonIpmsMeasurement>();
            Attributes = new List<object>();
        }
    }
}
