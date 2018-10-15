using System;

namespace csharp.Types
{
    public class LimitedUseMeasurement
    {
        public const String Annotation = "In certain markets there may be areas in buildings that are incapable of occupation in the light of government regulation or labour legislation. Such areas and their limitations are to be identified, measured and stated separately within IPMS reported areas. Users and third parties need to be aware that the inclusion of measured areas in IPMS does not mean the...???";
        public decimal MeasurementValue { get; set; }
        public AlternativeMeasurement AlternativeMeasurement { get; set; }
        public Enums.KnownLimitedUseCategory LimitedUseCategory { get; set; }
        public String Description { get; set; }

        public LimitedUseMeasurement()
        { }
    }
}
