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
    public class KidsController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public KidsController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/Kids
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kid>>> GetKid()
        {
            return await _context.Kid.ToListAsync();
        }

        // GET: api/Kids/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kid>> GetKid(long id)
        {
            var kid = await _context.Kid.FindAsync(id);

            if (kid == null)
            {
                return NotFound();
            }

            return kid;
        }

        // PUT: api/Kids/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKid(long id, Kid kid)
        {
            if (id != kid.ID)
            {
                return BadRequest();
            }

            _context.Entry(kid).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KidExists(id))
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

        // POST: api/Kids
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Kid>> PostKid(Kid kid)
        {
            _context.Kid.Add(kid);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKid", new { id = kid.ID }, kid);
        }

        // DELETE: api/Kids/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Kid>> DeleteKid(long id)
        {
            var kid = await _context.Kid.FindAsync(id);
            if (kid == null)
            {
                return NotFound();
            }

            _context.Kid.Remove(kid);
            await _context.SaveChangesAsync();

            return kid;
        }

        private bool KidExists(long id)
        {
            return _context.Kid.Any(e => e.ID == id);
        }
    }
}
