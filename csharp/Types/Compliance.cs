using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Compliance
    {
        public String ConflictsOfInterestNotes { get; set; }
        public string ConfidentialityNotes { get; set; }
        //public StatementOfProfessionalism StatementOfProfessionalism { get; set; }
        public string Departures { get; set; }
        public string TermsOfUse { get; set; }
        public string CertifiedBy { get; set; }
        public string DigitalSignature { get; set; }
        //public AnnotatedDocumentType SupportingDocumentation { get; set; }

        public Compliance()
        { }
    }
}
