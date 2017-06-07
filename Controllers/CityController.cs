using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RateExpert.Database;

namespace RateExpert.Controllers
{
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        private ICityRepository _repository;

        public CityController(ICityRepository repository)
        {
            _repository = repository;
        }

        // GET: api/city
        [HttpGet()]
        public async Task<IActionResult> Search()
        {
            try
            {
                var results = await _repository.Search();                
                return this.Ok(results);
            }
            catch (System.Exception e)
            {
                return this.BadRequest(e);
            }
        }

        // GET: api/city/5
        [HttpGet("{id}", Name = "GetCity")]
        public async Task<IActionResult> Get(long id)
        {
            try
            {
                var item = await _repository.Get(id);
                if (item == null)
                {
                    return NotFound();
                }
                return this.Ok(item);
            }
            catch (System.Exception e)
            {
                return this.BadRequest(e);
            }
        }        
    }
}
