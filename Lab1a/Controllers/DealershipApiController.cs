using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1a.Data;
using Lab1a.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab1a.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealershipApiController : ControllerBase
    {
        Lab1aContext _context;
        // GET: api/DealershipApi
       [HttpGet]
        public IEnumerable<Car> Get()
        {
            DealershipMgr mgr = new DealershipMgr();
            
            return mgr.GetCars();
        }

        // GET: api/DealershipApi/5
        [HttpGet("{id}", Name = "Get")]
        public Car Get(string id)
        {
            DealershipMgr mgr = new DealershipMgr();

            return mgr.GetCar(id);

        }

        // POST: api/DealershipApi
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/DealershipApi/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
   
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            DealershipMgr mgr = new DealershipMgr();

            mgr.DeleteCar(id);
        }
    }
}
