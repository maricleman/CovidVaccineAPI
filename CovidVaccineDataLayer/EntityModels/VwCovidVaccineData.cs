using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CovidVaccineDataLayer.EntityModels
{
    public partial class VwCovidVaccineData
    {
        public string DateOfReport { get; set; }
        public int? AgeInYears { get; set; }
        public string SymptomsDescription { get; set; }
        public string VaccineManufactured { get; set; }
        public string NumberOfDosesAdministered { get; set; }
        public string DiedBecauseOfVaccine { get; set; }
        public string LifeThreateningIllness { get; set; }
        public string EmergencyRoomOrDoctorVisit { get; set; }
        public string Hospitalized { get; set; }
        public string IsDisabled { get; set; }
        public string LabData { get; set; }
        public string OtherMedications { get; set; }
        public string IllnessAtTimeOfVaccination { get; set; }
        public string History { get; set; }
        public string PriorVaccinationInfo { get; set; }
        public string ClinicOrDoctorVisit { get; set; }
        public string EmergencyRoomVisit { get; set; }
        public string Allergies { get; set; }
        public string Symptom1 { get; set; }
        public string Symtom2 { get; set; }
        public string Symtom3 { get; set; }
        public string Symtom4 { get; set; }
        public string Symtom5 { get; set; }
        public string VaccinationName { get; set; }
    }
}
