using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RateExpert.Models;

namespace RateExpert.Database
{
    public interface ICityRepository
    {
        Task Create(City city);

        Task Update(City city);

        Task<City> Get(long id);

        Task<List<City>> Search();
    }
}
