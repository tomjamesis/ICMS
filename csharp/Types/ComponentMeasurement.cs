using System;
using System.Collections.Generic;

namespace csharp.Types
{
    public class ComponentMeasurement
    {
        public String Description { get; set; }
        //public List<Ipms1Measurement> Ipms1MeasuredFloorArea { get; set; }
        //public List<Ipms2Measurement> Ipms2MeasuredFloorArea { get; set; }
        public List<Ipms3Measurement> Ipms3MeasuredFloorArea { get; set; }
        //public Reference Reference { get; set; }
        public String UniclassCategory { get; set; }
        public Enums.KnownIpmsComponentArea ComponentArea { get; set; }
        public IpmsComponentUsage ComponentUsage { get; set; }
        public List<object> Attributes { get; set; }

        public ComponentMeasurement()
        {
            //Ipms1MeasuredFloorArea = new List<Ipms1Measurement>();
            //Ipms2MeasuredFloorArea = new List<Ipms2Measurement>();
            Ipms3MeasuredFloorArea = new List<Ipms3Measurement>();
            Attributes = new List<object>();
        }
    }
}
