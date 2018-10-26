using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Treatment : CostedProject
    {
        public TreatmentWorks Works { get; set; }
        public TreatmentQuantities Quantities { get; set; }

        public Treatment()
        { }
    }
}
