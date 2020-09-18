using AgrixemAPI.Core.Models.Production.Cattle;
using AgrixemAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Controllers.Production.Cows
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasturesController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public PasturesController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/Pastures
        [HttpGet("{farmId:int}")]
        public async Task<ActionResult<IEnumerable<Pasture>>> GetPasture(int farmId)
        {
            return await _context.Pasture.Where(e => e.FarmID == farmId).ToListAsync();
        }

        // GET: api/Pastures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pasture>> GetPasture(long id)
        {
            var pasture = await _context.Pasture.FindAsync(id);

            if (pasture == null)
            {
                return NotFound();
            }

            return pasture;
        }

        // PUT: api/Pastures/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPasture(long id, Pasture pasture)
        {
            if (id != pasture.ID)
            {
                return BadRequest();
            }

            _context.Entry(pasture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PastureExists(id))
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

        // POST: api/Pastures
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pasture>> PostPasture(Pasture pasture)
        {
            _context.Pasture.Add(pasture);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPasture", new { id = pasture.ID }, pasture);
        }

        // DELETE: api/Pastures/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pasture>> DeletePasture(long id)
        {
            var pasture = await _context.Pasture.FindAsync(id);
            if (pasture == null)
            {
                return NotFound();
            }

            _context.Pasture.Remove(pasture);
            await _context.SaveChangesAsync();

            return pasture;
        }

        private bool PastureExists(long id)
        {
            return _context.Pasture.Any(e => e.ID == id);
        }
    }
}
