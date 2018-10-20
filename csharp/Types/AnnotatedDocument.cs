using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class AnnotatedDocument
    {
        public List<String> Description { get; set; }
        //public FileType File { get; set; }
        public DateTime Created { get; set; }
        public List<String> Scale { get; set; }
        public MeasurementProperty MeasurementPropertyReference { get; set; }

        public AnnotatedDocument()
        {
            Description = new List<String>();
            Scale = new List<String>();
        }
    }
}
