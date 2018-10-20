using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Meta
    {
        //public Entity PropertyType { get; set; }

        public List<string> PreparedFor { get; set; }
        public List<Compliance> Compliance { get; set; }
        public DateTime ReportDate { get; set; }
        public List<string> Brief { get; set; }
        public List<string> ScopeOfWork { get; set; }
        public string Methodology { get; set; }
        public Verification Verification { get; set; }
        public List<AnnotatedDocument> OtherDocumentation { get; set; }

        public Meta()
        {
            PreparedFor = new List<string>();
            Compliance = new List<Compliance>();
            Brief = new List<string>();
            ScopeOfWork = new List<string>();
            OtherDocumentation = new List<AnnotatedDocument>();
        }
    }
}
