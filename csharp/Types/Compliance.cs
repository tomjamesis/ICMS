using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Compliance
    {
        public String ConflictsOfInterestNotes { get; set; }
        public string ConfidentialityNotes { get; set; }
        public List<object> StatementOfProfessionalism { get; set; }
        public string Departures { get; set; }
        public string TermsOfUse { get; set; }
        public string CertifiedBy { get; set; }
        public string DigitalSignature { get; set; }
        public AnnotatedDocument SupportingDocumentation { get; set; }

        public Compliance()
        {
            StatementOfProfessionalism = new List<object>();
        }
    }
}
