using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class SiteStatus
    {
        public Enums.SiteStateOfUse stateOfUse { get; set; }
        public Enums.SiteTypeOfUse typeOfUse { get; set; }
        public Enums.KnownSiteLegalStatus legalStatus { get; set; }
        public Enums.KnownTopography siteTopography { get; set; }
        public Enums.GroundConditions groundConditions { get; set; }
        public Enums.DifficultyRating accessProblems { get; set; }
        public Enums.DifficultyRating extremeClimaticConditions { get; set; }
        public Enums.DifficultyRating environmentalConstraints { get; set; }

        public SiteStatus()
        { }
    }
}
