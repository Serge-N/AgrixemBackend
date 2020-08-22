using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgrixemAPI.Core.Models.Production.Cattle;
using AgrixemAPI.Data;

namespace AgrixemAPI.Controllers.Production.Cows
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrowthsController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public GrowthsController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/Growths
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Growth>>> GetGrowth()
        {
            return await _context.Growth.ToListAsync();
        }

        // GET: api/Growths/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Growth>> GetGrowth(long id)
        {
            var Growth = await _context.Growth.ToListAsync();
            var growth = Growth.FirstOrDefault(e => e.CattleFK == id);

            if (growth == null)
            {
                return NotFound();
            }

            return growth;
        }

        // PUT: api/Growths/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrowth(long id, Growth growth)
        {
            if (id != growth.CattleID)
            {
                return BadRequest();
            }

            _context.Entry(growth).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrowthExists(id))
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

        // POST: api/Growths
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Growth>> PostGrowth(Growth growth)
        {
            _context.Growth.Add(growth);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGrowth", new { id = growth.CattleID }, growth);
        }

        // DELETE: api/Growths/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Growth>> DeleteGrowth(long id)
        {
            var growth = await _context.Growth.FindAsync(id);
            if (growth == null)
            {
                return NotFound();
            }

            _context.Growth.Remove(growth);
            await _context.SaveChangesAsync();

            return growth;
        }

        private bool GrowthExists(long id)
        {
            return _context.Growth.Any(e => e.CattleID == id);
        }
    }
}
