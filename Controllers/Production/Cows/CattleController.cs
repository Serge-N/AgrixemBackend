using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgrixemAPI.Core.Models.Production.Cattle;
using AgrixemAPI.Data;

namespace AgrixemAPI.Controllers.Production.Cows
{
    [Route("api/[controller]")]
    [ApiController]
    public class CattleController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public CattleController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/Cattle/farm/2
        [HttpGet("farm/{id:int}")]
        public async Task<ActionResult<IEnumerable<Cattle>>> GetCattle(int id)
        {
            return await _context.Cattle.Where(e => e.FarmID==id).ToListAsync();
        }

        // GET: api/Cattle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cattle>> GetCattle(long id)
        {
            var cattle = await _context.Cattle.FindAsync(id);

            if (cattle == null)
            {
                return NotFound();
            }

            return cattle;
        }

        // PUT: api/Cattle/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCattle(long id, Cattle cattle)
        {
            if (id != cattle.ID)
            {
                return BadRequest();
            }

            _context.Entry(cattle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CattleExists(id))
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

        // POST: api/Cattle
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cattle>> PostCattle(Cattle cattle)
        {
            _context.Cattle.Add(cattle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCattle", new { id = cattle.ID }, cattle);
        }

        // DELETE: api/Cattle/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cattle>> DeleteCattle(long id)
        {
            var cattle = await _context.Cattle.FindAsync(id);
            if (cattle == null)
            {
                return NotFound();
            }

            _context.Cattle.Remove(cattle);
            await _context.SaveChangesAsync();

            return cattle;
        }

        private bool CattleExists(long id)
        {
            return _context.Cattle.Any(e => e.ID == id);
        }
    }
}
