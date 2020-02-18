using System.Threading.Tasks;
using StubscribeAngular.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace StubscribeAngular.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubServicesController : ControllerBase
    {
        private readonly DataContext _context;
        public SubServicesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var services = await _context.SubServices.ToListAsync();
            
            return Ok(services);
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetAction(int id)
        {
            var services = _context.SubServices.FirstOrDefaultAsync(x => x.id == id);
            // return "value";
            return Ok(services);
        }
    }
}