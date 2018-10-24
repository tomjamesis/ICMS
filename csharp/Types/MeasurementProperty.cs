using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class MeasurementProperty
    {
        public AddressDetails AddressDetails { get; set; }
        public List<Floors> Floors { get; set; }
        public List<FloorPlan> FloorPlans { get; set; }
        public List<IpmsMeasurement> Ipms1Measurements { get; set; }
        public List<IpmsMeasurement> Ipms2Measurements { get; set; }
        public List<Ipms3Measurement> Ipms3Measurements { get; set; }
        public List<NonIpmsMeasurement> NonIpmsMeasurements { get; set; }
        public BuildingUse BuildingUse { get; set; }
        public String Reference { get; set; }


        public MeasurementProperty()
        {
            Floors = new List<Floors>();
            FloorPlans = new List<FloorPlan>();
            Ipms1Measurements = new List<IpmsMeasurement>();
            Ipms2Measurements = new List<IpmsMeasurement>();
            Ipms3Measurements = new List<Ipms3Measurement>();
            NonIpmsMeasurements = new List<NonIpmsMeasurement>();
        }
    }
}
