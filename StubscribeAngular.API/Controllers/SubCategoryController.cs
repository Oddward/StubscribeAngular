using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StubscribeAngular.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace StubscribeAngular.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly DataContext _context;
        public SubCategoryController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var categories = await _context.SubCategories.ToListAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetAction(int id)
        {
            var categories = _context.SubCategories.FirstOrDefaultAsync(x => x.id == id);
            // return "value";
            return Ok(categories);
        }
    }
}