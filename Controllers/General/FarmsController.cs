using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgrixemAPI.Core.Models.General;
using AgrixemAPI.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace AgrixemAPI.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmsController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public FarmsController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/Farms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Farms>>> GetFarms()
        {
            return await _context.Farms.ToListAsync();
        }

        // GET: api/Farms/5
        [HttpGet("{id}")]
        
        public async Task<ActionResult<Farms>> GetFarms(int id)
        {
            var farms = await _context.Farms.FindAsync(id);

            if (farms == null)
            {
                return NotFound();
            }

            return farms;
        }

        // PUT: api/Farms/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFarms(int id, Farms farms)
        {
            if (id != farms.ID)
            {
                return BadRequest();
            }

            _context.Entry(farms).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FarmsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Farms
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Farms>> PostFarms(Farms farms)
        {
            _context.Farms.Add(farms);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFarms", new { id = farms.ID }, farms);
        }

        // DELETE: api/Farms/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Farms>> DeleteFarms(int id)
        {
            var farms = await _context.Farms.FindAsync(id);
            if (farms == null)
            {
                return NotFound();
            }

            _context.Farms.Remove(farms);
            await _context.SaveChangesAsync();

            return farms;
        }

        private bool FarmsExists(int id)
        {
            return _context.Farms.Any(e => e.ID == id);
        }
    }
}
