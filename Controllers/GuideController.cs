using Microsoft.AspNetCore.Mvc;
using trips.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace trips.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuideController : ControllerBase
    {

        private static List<Guide> guides = new List<Guide>
        {
            new Guide { name_guide = "Dani",guide_id = "3333" , guide_email = "dddd"},
            new Guide { name_guide = "Yoni", guide_id = "444", guide_email = "yyy"}
        };


        // GET: api/<GuideController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GuideController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GuideController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GuideController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GuideController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
