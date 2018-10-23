using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class SeaLevelHeight : SimpleMeasurement
    {
        public Enums.AboveBelow location { get; set; }

        public SeaLevelHeight()
        { }
    }
}
