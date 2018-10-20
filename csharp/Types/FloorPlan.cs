using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class FloorPlan
    {
        public List<AnnotatedDocument> Content { get; set; }

        public FloorPlan()
        {
            Content = new List<AnnotatedDocument>();
        }
    }
}
