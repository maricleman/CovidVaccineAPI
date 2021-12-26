using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CovidVaccineDataLayer.EntityModels
{
    public partial class Vaersdata
    {
        public int YearRecorded { get; set; }
        public int VaersId { get; set; }
        public string DateOfReport { get; set; }
        public string State { get; set; }
        public decimal? AgeInYears { get; set; }
        public int? CalculatedAgeInYears { get; set; }
        public decimal? CalculatedAgeInMonths { get; set; }
        public string Gender { get; set; }
        public string ReportedDate { get; set; }
        public string SymptomsDescription { get; set; }
        public string DiedBecauseOfVaccine { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public string LifeThreateningIllness { get; set; }
        public string EmergencyRoomOrDoctorVisit { get; set; }
        public string Hospitalized { get; set; }
        public int? NumberOfDaysHospitalized { get; set; }
        public string ProlongationOfExitingHospitalization { get; set; }
        public string IsDisabled { get; set; }
        public string HasRecovered { get; set; }
        public DateTime? VaccinationDate { get; set; }
        public DateTime? AdverseEventOnsetDate { get; set; }
        public int? NumberOfDaysSuffered { get; set; }
        public string LabData { get; set; }
        public string VaccineAdministeredBy { get; set; }
        public string VaccineFundedBy { get; set; }
        public string OtherMedications { get; set; }
        public string IllnessAtTimeOfVaccination { get; set; }
        public string History { get; set; }
        public string PriorVaccinationInfo { get; set; }
        public string ManufacturerProjectReportNumber { get; set; }
        public int? FormVersionNumber { get; set; }
        public DateTime? DateFormCompleted { get; set; }
        public string BirthDefects { get; set; }
        public string ClinicOrDoctorVisit { get; set; }
        public string EmergencyRoomVisit { get; set; }
        public string Allergies { get; set; }
    }
}
