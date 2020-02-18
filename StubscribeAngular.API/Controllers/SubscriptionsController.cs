using System.Threading.Tasks;
using StubscribeAngular.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace StubscribeAngular.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        private readonly DataContext _context;
        public SubscriptionsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var subscriptions = await _context.Subscriptions.ToListAsync();
            return Ok(subscriptions);
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetAction(int id)
        {
            var subscriptions = _context.Subscriptions.FirstOrDefaultAsync(x => x.id == id);
            // return "value";
            return Ok(subscriptions);
        }
    }
}