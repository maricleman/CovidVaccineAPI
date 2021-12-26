using CovidVaccineDataLayer.Repositories;
using CovidVaccineModels.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidVaccineBusinessLogic
{
    public class GetVaccinationDeaths : IGetVaccinationDeaths
    {
        private readonly ICovidVaccineDbRepository covidVaccineDbRepository;

        public GetVaccinationDeaths(ICovidVaccineDbRepository covidVaccineDbRepository)
        {
            this.covidVaccineDbRepository = covidVaccineDbRepository;
        }
        public List<CovidVaccineInfo> GetDeathsByAge()
        {
            var results = covidVaccineDbRepository.GetDeathsByAge();
            return results;
        }
    }
}
