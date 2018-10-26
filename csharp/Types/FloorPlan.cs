using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class FloorPlan : AnnotatedDocument
    {
        //public List<String> Scale { get; set; } //Already exists within AnnotatedDocument object
        public List<String> CreatedBy { get; set; }

        public FloorPlan()
        {
            //Scale = new List<string>();
            CreatedBy = new List<string>();
        }
    }
}
