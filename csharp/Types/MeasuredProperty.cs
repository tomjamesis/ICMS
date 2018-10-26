using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class MeasuredProperty
    {
        public List<AddressDetails> AddressDetails { get; set; }
        public List<Floors> Floors { get; set; }
        public List<FloorPlan> FloorPlan { get; set; }
        public List<IpmsMeasurement> Ipms1Measurements { get; set; }
        public List<IpmsMeasurement> Ipms2Measurements { get; set; }
        public List<Ipms3Measurement> Ipms3Measurements { get; set; }
        public List<NonIpmsMeasurement> NonIpmsMeasurements { get; set; }
        public RoadAndMotorwayUse primaryUse { get; set; }
        public String reference { get; set; }


        public MeasuredProperty()
        {
            AddressDetails = new List<AddressDetails>();
            Floors = new List<Floors>();
            FloorPlan = new List<FloorPlan>();
            Ipms1Measurements = new List<IpmsMeasurement>();
            Ipms2Measurements = new List<IpmsMeasurement>();
            Ipms3Measurements = new List<Ipms3Measurement>();
            NonIpmsMeasurements = new List<NonIpmsMeasurement>();
        }
    }
}
