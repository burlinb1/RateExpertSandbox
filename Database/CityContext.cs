using Microsoft.EntityFrameworkCore;
using RateExpert.Models;

namespace RateExpert.Database
{
    public class CityContext : DbContext
    {
        public CityContext(DbContextOptions<CityContext> options) : base(options)
        {
        }

        public DbSet<City> City { get; set; }
    }
}
