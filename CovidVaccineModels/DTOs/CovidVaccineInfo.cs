using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidVaccineModels.DTOs
{
    public class CovidVaccineInfo
    {
        public DateTime DateOfReport { get; set; }
        public int AgeInYears { get; set; }
        public string SymptomDescription { get; set; }
        public string VaccineManufactured { get; set; }
        public int NumberOfDosesAdministered { get; set; }
        public bool DiedBecauseOfVaccine { get; set; }
        public bool LifeThreateningIllness { get; set; }
        public bool EmergencyRoomOrDoctorVisit { get; set; }
        public bool Hospitalized { get; set; }
        public bool IsDisabled { get; set; }
        public string History { get; set; }
        public string VaccinationName { get; set; }
    }
}
