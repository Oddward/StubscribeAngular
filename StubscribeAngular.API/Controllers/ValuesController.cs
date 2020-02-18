using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StubscribeAngular.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context; //conventional(?) to add _ before private var, instead of using this.
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        // public ActionResult<IEnumerable<string>> GetAction()
        {
            //get the values from db into a list
            var values = await _context.Values.ToListAsync();
            ////    return new string[] {"Value 1", "Value 2", "Value 3"};
            //Ok to return an http response 200 code
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        // public async Task<IActionResult> GetValue(int id)
        public ActionResult<string> GetAction(int id)
        {
            // var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return "value";
            // return Ok(value);
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
    }
}
