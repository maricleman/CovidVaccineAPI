using CovidVaccineModels.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidVaccineDataLayer.Repositories
{
    public interface ICovidVaccineDbRepository
    {
        List<CovidVaccineInfo> GetDeathsByAge();
    }
}
