using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class MeasurementProperty
    {
        public AddressDetails AddressDetails { get; set; }
        //public List<Floors> Floors { get; set; }
        //public List<FloorPlans> FloorPlans { get; set; }
        //public List<Ipms1MeasuredArea> Ipms1MeasuredAreas { get; set; }
        //public List<Ipms2MeasuredArea> Ipms2MeasuredAreas { get; set; }
        //public List<Ipms3MeasuredArea> Ipms3MeasuredAreas { get; set; }
        //public List<NonIpmsMeasuredArea> NonIpmsMeasuredAreas { get; set; }
        public BuildingUse BuildingUse { get; set; }
        //public Reference Reference { get; set; }


        public MeasurementProperty()
        {
            //Floors = new List<Floors>();
            //FloorPlans = new List<FloorPlans>();
            //Ipms1MeasuredAreas = new List<Ipms1MeasuredArea>();
            //Ipms2MeasuredAreas = new List<Ipms2MeasuredArea>();
            //Ipms3MeasuredAreas = new List<Ipms3MeasuredArea>();
            //NonIpmsMeasuredAreas = new List<NonIpmsMeasuredArea>();
        }
    }
}
