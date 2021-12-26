using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CovidVaccineDataLayer.EntityModels
{
    public partial class Vaerssymptoms
    {
        public int YearRecorded { get; set; }
        public int VaersId { get; set; }
        public string Symptom1 { get; set; }
        public decimal SymptomVersion1 { get; set; }
        public string Symptom2 { get; set; }
        public decimal? SymptomVersion2 { get; set; }
        public string Symptom3 { get; set; }
        public decimal? SymptomVersion3 { get; set; }
        public string Symptom4 { get; set; }
        public decimal? SymptomVersion4 { get; set; }
        public string Symptom5 { get; set; }
        public decimal? SymptomVersion5 { get; set; }
    }
}
