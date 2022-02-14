using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleAPI;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {
            var peopleListing = GetPeople();
            return peopleListing;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Correct Response";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public List<Person> GetPeople()
        {
            var people = new List<Person>();
            people.Add(new Person{FirsName ="Keagen", LastName = "Reddy", Region = "SA"});
            people.Add(new Person{FirsName ="Barry", LastName = "Ahern", Region = "SA"});
            people.Add(new Person{FirsName ="Ivan", LastName = "van den Bergh", Region = "SA"});
            people.Add(new Person{FirsName ="Paul", LastName = "Steinrisser", Region = "EU"});
            people.Add(new Person{FirsName ="Reinhard", LastName = "Schrei", Region = "EU"});
            //people.Add(new Person{FirsName ="Dave", LastName = "Shepherd", Region = "SA"});

            return people;
        }
    }
}
