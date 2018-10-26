using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class AnnotatedDocument
    {
        public List<String> Description { get; set; }
        public File.External File { get; set; }
        public DateTime Created { get; set; }
        public List<String> Scale { get; set; }
        public MeasuredProperty MeasurementPropertyReference { get; set; }

        public AnnotatedDocument()
        {
            Description = new List<String>();
            Scale = new List<String>();
        }
    }
}
