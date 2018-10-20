using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class ClassificationStandard
    {
        public Enums.KnownProjectClassificationStandardName StandardName { get; set; }
        public string Code { get; set; }

        public ClassificationStandard()
        { }
    }
}
