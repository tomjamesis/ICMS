using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class RangedDimension
    {
        public List<dimension> Dimensions { get; set; }
        public enum dimension
        {
            Minimum,
            Maximum
        }

        public RangedDimension()
        {
            Dimensions = new List<dimension>();
        }
    }
}
