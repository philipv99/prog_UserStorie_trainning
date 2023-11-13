using Microsoft.AspNetCore.Mvc;
using UserStorie_school_assignment.Reposetorys;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserStorie_school_assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase
    {

        MusicRecordsReposetory _Repo;
        public MusicRecordsController(MusicRecordsReposetory records_repo)
        {
            _Repo = records_repo;
        }


        // GET: api/<MusicRecordsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MusicRecordsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MusicRecordsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MusicRecordsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MusicRecordsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
