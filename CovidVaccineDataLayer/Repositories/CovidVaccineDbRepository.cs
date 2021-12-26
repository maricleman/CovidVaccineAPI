using CovidVaccineDataLayer.DbContexts;
using CovidVaccineModels.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CovidVaccineDataLayer.Repositories
{
    public class CovidVaccineDbRepository: ICovidVaccineDbRepository
    {
        private readonly CovidVaccineDbContext covidVaccineDbContext;

        public CovidVaccineDbRepository(CovidVaccineDbContext covidVaccineDbContext)
        {
            this.covidVaccineDbContext = covidVaccineDbContext;
        }

        public List<CovidVaccineInfo> GetDeathsByAge()
        {
            var results = covidVaccineDbContext.VwCovidVaccineData.Where(x => x.DiedBecauseOfVaccine == "Y")
                                                        .Where(x => x.AgeInYears >= 20)
                                                        .Where(x => x.AgeInYears <= 30)
                                                        .Select(x => new CovidVaccineInfo()
                                                        {
                                                            DateOfReport = DateTime.Parse(x.DateOfReport),
                                                            AgeInYears = x.AgeInYears ?? 0,
                                                            SymptomDescription = x.SymptomsDescription,
                                                            VaccineManufactured = x.VaccineManufactured,
                                                            NumberOfDosesAdministered = Convert.ToInt32(x.NumberOfDosesAdministered),
                                                            DiedBecauseOfVaccine = x.DiedBecauseOfVaccine == "Y",
                                                            LifeThreateningIllness = x.LifeThreateningIllness == "Y",
                                                            EmergencyRoomOrDoctorVisit = x.EmergencyRoomOrDoctorVisit == "Y",
                                                            Hospitalized = x.Hospitalized == "Y",
                                                            IsDisabled = x.IsDisabled == "Y",
                                                            History = x.History,
                                                            VaccinationName = x.VaccinationName
                                                        })
                                                        .ToList();
            return results;
        }
    }
}
