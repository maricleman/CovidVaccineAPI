using CovidVaccineBusinessLogic;
using CovidVaccineModels.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidVaccineAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GetCovidVaccineInfoController : ControllerBase
    {
        private readonly IGetVaccinationDeaths getVaccinationDeaths;

        public GetCovidVaccineInfoController(IGetVaccinationDeaths getVaccinationDeaths)
        {
            this.getVaccinationDeaths = getVaccinationDeaths;
        }

        public List<CovidVaccineInfo> GetDeathsByAge()
        {
            var results = getVaccinationDeaths.GetDeathsByAge();
            return results;
        }
    }
}
