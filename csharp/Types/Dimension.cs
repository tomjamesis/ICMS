using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Dimension
    {
        public List<Choice> DimensionType { get; set; }
        public UnitOfMeasurement unitOfMeasurement { get; set; }
        public String Description { get; set; }

        public enum Choice
        {
            Width,
            Length,
            Height
        }

        public Dimension()
        {
            DimensionType = new List<Choice>();
        }
    }
}
