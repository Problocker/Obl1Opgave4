using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CykelModelLib.model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestCykelService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CyklerController : ControllerBase
    {
        private static readonly List<Cykel> cykler = new List<Cykel>()
        {
            new Cykel(1,"Carbon",99995.95,22),
            new Cykel(2,"Limegrøn",4795.65,6),
            new Cykel(3,"Marineblå",12000,36),
            new Cykel(4,"Bordeauxrød",1200,3),
            new Cykel(5,"Citrongul",18000,12),
            new Cykel(6,"Frederiksberg-grøn",4269,18),
            new Cykel(7,"Pantone Maersk Blue",87865,32),
            new Cykel(8,"Ridderspore",8888,14),
            new Cykel(9,"Hvid",27000,9),
            new Cykel(10,"Kongeblå",7769.42,15)
        };



        // GET: api/<CyklerController>
        [HttpGet]
        public IEnumerable<Cykel> Get()
        {
            return cykler;
        }

        // GET api/<CyklerController>/5
        [HttpGet("{id}")]
        public Cykel Get(int id)
        {
            return cykler.Find(c => c.Id == id);
        }

        // POST api/<CyklerController>
        [HttpPost]
        public void Post([FromBody] Cykel value)
        {
            cykler.Add(value);
        }

        // PUT api/<CyklerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cykel value)
        {
            Cykel cykel = Get(id);
            if (cykel != null)
            {
                cykel.Id = value.Id;
                cykel.Farve = value.Farve;
                cykel.Pris = value.Pris;
                cykel.Gear = value.Gear;
            }
        }

        // DELETE api/<CyklerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Cykel cykel = Get(id);
            cykler.Remove(cykel);
        }
    }
}
