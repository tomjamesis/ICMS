using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class SimpleMeasurement : SimpleDecimal
    {
        public UnitOfMeasurement unitOfMeasurement { get; set; }

        public SimpleMeasurement()
        { }
    }
}
