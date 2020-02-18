using System.Threading.Tasks;
using System.Collections.Generic;
using StubscribeAngular.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace StubscribeAngular.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly DataContext _context;
        public MembersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var members = await _context.Members.ToListAsync();
            return Ok(members);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAction(int id)
        {
            var sql = "select * from Members WHERE SubscriptionId is " + id + ";";
            var members = await _context.Members.FromSqlRaw(sql).ToListAsync();
            
            return Ok(members);
        }
        // private readonly int subId;

        [HttpGet("{subId}/{id}")]
            // this.subId = subId;
        public async Task<IActionResult> GetMember(int subId,int id)
        {
            var sql = "select * from Members WHERE SubscriptionId is " + subId + " AND id is " + id + ";";
            var member = await _context.Members.FromSqlRaw(sql).ToListAsync();

            return Ok(member);
        }

        // [HttpGet("{subId}/count")]
        // public async Task<IActionResult> GetMembersCount(int subId)
        // {
        //     var sql = "select Count(name) from Members WHERE SubscriptionId is " + subId + ";";
        //     var memberCount = _context.Members.FromSqlRaw(sql);

        //     return Ok(memberCount);
        // }
    }
}