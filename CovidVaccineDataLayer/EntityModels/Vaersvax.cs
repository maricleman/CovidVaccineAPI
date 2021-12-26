using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CovidVaccineDataLayer.EntityModels
{
    public partial class Vaersvax
    {
        public int YearRecorded { get; set; }
        public int VaersId { get; set; }
        public string AdministeredVaccineType { get; set; }
        public string VaccineManufactured { get; set; }
        public string VaccineManufacturerLot { get; set; }
        public string NumberOfDosesAdministered { get; set; }
        public string VaccineRoute { get; set; }
        public string VaccinationSite { get; set; }
        public string VaccinationName { get; set; }
    }
}
