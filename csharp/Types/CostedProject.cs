using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class CostedProject : Project
    {
        public Enums.KnownProjectClassificationStandardName ClassificationStandard { get; set; }

        public CostedProject()
        { }
    }
}
