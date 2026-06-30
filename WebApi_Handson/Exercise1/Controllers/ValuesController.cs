using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static List<string> values = new List<string>()
        {
            "Value1",
            "Value2",
            "Value3"
        };

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(values);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 0 || id >= values.Count)
                return NotFound();

            return Ok(values[id]);
        }

        // POST: api/values
        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            values.Add(value);
            return Ok("Value Added Successfully");
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string value)
        {
            if (id < 0 || id >= values.Count)
                return BadRequest();

            values[id] = value;
            return Ok("Value Updated Successfully");
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0 || id >= values.Count)
                return BadRequest();

            values.RemoveAt(id);
            return Ok("Value Deleted Successfully");
        }
    }
}
