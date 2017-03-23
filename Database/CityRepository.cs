using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RateExpert.Models;
using Microsoft.EntityFrameworkCore;

namespace RateExpert.Database
{
    public class CityRepository : ICityRepository
    {
        private CityContext _context;

        public CityRepository(CityContext context)
        {
            _context = context;
        }

        public Task Create(City city)
        {
            _context.City.Add(city);
            return _context.SaveChangesAsync();
        }

        public Task Update(City city)
        {
            var entry = _context.City.Add(city);
            entry.State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }
        
        public Task<City> Get(long id)
        {
            //return _context.City.Include(child => child.State).SingleOrDefaultAsync<City>(qry => qry.Id == id);
            return _context.City.SingleOrDefaultAsync<City>(qry => qry.Id == id);
        }

        public Task<List<City>> Search()
        {
            return _context.City.ToListAsync<City>();
        }
    }
}
