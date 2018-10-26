using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Meta
    {
        public Property Entity { get; set; }

        public List<String> PreparedFor { get; set; }
        public List<Compliance> Compliance { get; set; }
        public DateTime ReportDate { get; set; }
        public List<String> Brief { get; set; }
        public List<String> ScopeOfWork { get; set; }
        public string Methodology { get; set; }
        public Verification Verification { get; set; }
        public List<AnnotatedDocument> OtherDocumentation { get; set; }

        public Meta()
        {
            PreparedFor = new List<String>();
            Compliance = new List<Compliance>();
            Brief = new List<String>();
            ScopeOfWork = new List<String>();
            OtherDocumentation = new List<AnnotatedDocument>();
        }
    }
}
