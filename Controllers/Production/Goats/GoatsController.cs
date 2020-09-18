using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgrixemAPI.Core.Models.Production.Goats;
using AgrixemAPI.Data;

namespace AgrixemAPI.Controllers.Production.Goats
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoatsController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public GoatsController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/Goats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Goat>>> GetGoat()
        {
            return await _context.Goat.ToListAsync();
        }

        // GET: api/Goats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Goat>> GetGoat(long id)
        {
            var goat = await _context.Goat.FindAsync(id);

            if (goat == null)
            {
                return NotFound();
            }

            return goat;
        }

        // PUT: api/Goats/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGoat(long id, Goat goat)
        {
            if (id != goat.ID)
            {
                return BadRequest();
            }

            _context.Entry(goat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GoatExists(id))
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

        // POST: api/Goats
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Goat>> PostGoat(Goat goat)
        {
            _context.Goat.Add(goat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGoat", new { id = goat.ID }, goat);
        }

        // DELETE: api/Goats/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Goat>> DeleteGoat(long id)
        {
            var goat = await _context.Goat.FindAsync(id);
            if (goat == null)
            {
                return NotFound();
            }

            _context.Goat.Remove(goat);
            await _context.SaveChangesAsync();

            return goat;
        }

        private bool GoatExists(long id)
        {
            return _context.Goat.Any(e => e.ID == id);
        }
    }
}
