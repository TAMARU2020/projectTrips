using Microsoft.AspNetCore.Mvc;
using trips.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace trips.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelersController : ControllerBase
    {
        private static List<Travelers> travelers = new List<Travelers>
        {
            new Travelers { name_travel = "Avi" , travel_id = "111", travel_age = 20 , travel_email = "aaa", travel_target =  },
             new Travelers { name_travel = "Sami" , travel_id = "555", travel_age = 25 , travel_email = "sss", travel_target =  }
        }

       // GET: api/<TravelersController>
       [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TravelersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TravelersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TravelersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TravelersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
