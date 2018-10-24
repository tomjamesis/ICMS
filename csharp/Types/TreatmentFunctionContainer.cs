using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class TreatmentFunctionContainer
    {
        public List<TreatmentFunction> Function { get; set; }

        public TreatmentFunctionContainer()
        {
            Function = new List<TreatmentFunction>();
        }
    }
}
