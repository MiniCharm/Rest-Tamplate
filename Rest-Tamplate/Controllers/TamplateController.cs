using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rest_Tamplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TamplateController : ControllerBase
    {
        //Use injection
        //private InterfaceNavn _kaldenavn
        public TamplateController()
        {
            
        }

        // GET: api/<TamplateController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TamplateController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TamplateController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public void Post([FromBody] string value)
        {
            //string URI = Url.RouteUrl(RouteData.Values) + "/" + objectets pk;
            //return Created(URI, hele object);
        }

        // PUT api/<TamplateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TamplateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
