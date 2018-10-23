using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class EnvironmentalGrade
    {
        public String StandardName { get; set; }
        public String Grade { get; set; }
        public Enums.GradeStatus GradeStatus { get; set; }

        public EnvironmentalGrade()
        { }
    }
}
