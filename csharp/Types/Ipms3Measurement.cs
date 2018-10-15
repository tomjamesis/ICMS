using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Ipms3Measurement
    {
        //public KnownFileCategory FileCategory { get; set; }
        //public KnownIpms3Measurement KnownIpms3Measurement { get; set; }
        public List<String> MeasurementSubType { get; }

        public Ipms3Measurement()
        {
            MeasurementSubType = new List<String>();
            MeasurementSubType.Add("3 - Office");
            MeasurementSubType.Add("3A - Industrial");
            MeasurementSubType.Add("3B - Industrial");
            MeasurementSubType.Add("3A - Residential, which equates closely to the former GEA (gross external area) at level 0 (ground level)");
            MeasurementSubType.Add("3B - Residential, which equates closely to the former GIA (gross internal area) at level 0 (ground level)");
            MeasurementSubType.Add("3C - Residential, which equates somewhat to the former NIA (net internal area), sometimes also referred to as net lettable area, net usable area, carpet area or other descriptions");
            MeasurementSubType.Add("3A - Retail");
            MeasurementSubType.Add("3B - Retail");
            MeasurementSubType.Add("3C - Retail");
        }
    }
}
