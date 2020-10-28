using System;

namespace VddiDigiSign.Models
{
    public class DigiSignature
    {
        public int DigiSignatureId { get; set; }
        public string ResidentId { get; set; }
        public string ResidentInitial { get; set; }
        public string ResidentSignature { get; set; }
        public string SalesInitial { get; set; }
        public string SalesSignature { get; set; }
        public string WitnessInitial { get; set; }
        public string WitnessSignature { get; set; }
        public string WitnessName { get; set; }
        public string AddedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public string OtpNo { get; set; }
        public string ServerPath { get; set; }

    }
}
