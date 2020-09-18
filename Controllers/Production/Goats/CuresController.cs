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
    public class CuresController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public CuresController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/Cures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cure>>> GetCure()
        {
            return await _context.Cure.ToListAsync();
        }

        // GET: api/Cures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cure>> GetCure(long id)
        {
            var cure = await _context.Cure.FindAsync(id);

            if (cure == null)
            {
                return NotFound();
            }

            return cure;
        }

        // PUT: api/Cures/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCure(long id, Cure cure)
        {
            if (id != cure.ID)
            {
                return BadRequest();
            }

            _context.Entry(cure).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CureExists(id))
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

        // POST: api/Cures
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cure>> PostCure(Cure cure)
        {
            _context.Cure.Add(cure);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCure", new { id = cure.ID }, cure);
        }

        // DELETE: api/Cures/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cure>> DeleteCure(long id)
        {
            var cure = await _context.Cure.FindAsync(id);
            if (cure == null)
            {
                return NotFound();
            }

            _context.Cure.Remove(cure);
            await _context.SaveChangesAsync();

            return cure;
        }

        private bool CureExists(long id)
        {
            return _context.Cure.Any(e => e.ID == id);
        }
    }
}
