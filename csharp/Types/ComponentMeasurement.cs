using System;
using System.Collections.Generic;

namespace csharp.Types
{
    public class ComponentMeasurement
    {
        public String Description { get; set; }
        public List<IpmsMeasurement> Ipms1MeasuredFloorArea { get; set; }
        public List<IpmsMeasurement> Ipms2MeasuredFloorArea { get; set; }
        public List<Ipms3Measurement> Ipms3MeasuredFloorArea { get; set; }
        public String reference { get; set; }
        public String uniclassCategory { get; set; }
        public Enums.KnownIpmsComponentArea ComponentArea { get; set; }
        public IpmsComponentUsage ComponentUsage { get; set; }
        public List<object> Attributes { get; set; }

        public ComponentMeasurement()
        {
            Ipms1MeasuredFloorArea = new List<IpmsMeasurement>();
            Ipms2MeasuredFloorArea = new List<IpmsMeasurement>();
            Ipms3MeasuredFloorArea = new List<Ipms3Measurement>();
            Attributes = new List<object>();
        }
    }
}
