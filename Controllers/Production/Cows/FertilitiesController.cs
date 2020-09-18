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
    public class FertilitiesController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public FertilitiesController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/Fertilities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fertility>>> GetFertility()
        {
            return await _context.Fertility.ToListAsync();
        }

        // GET: api/Fertilities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fertility>> GetFertility(long id)
        {
            var fertility = await _context.Fertility.FindAsync(id);

            if (fertility == null)
            {
                return NotFound();
            }

            return fertility;
        }

        // PUT: api/Fertilities/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFertility(long id, Fertility fertility)
        {
            if (id != fertility.ID)
            {
                return BadRequest();
            }

            _context.Entry(fertility).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FertilityExists(id))
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

        // POST: api/Fertilities
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Fertility>> PostFertility(Fertility fertility)
        {
            _context.Fertility.Add(fertility);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFertility", new { id = fertility.ID }, fertility);
        }

        // DELETE: api/Fertilities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Fertility>> DeleteFertility(long id)
        {
            var fertility = await _context.Fertility.FindAsync(id);
            if (fertility == null)
            {
                return NotFound();
            }

            _context.Fertility.Remove(fertility);
            await _context.SaveChangesAsync();

            return fertility;
        }

        private bool FertilityExists(long id)
        {
            return _context.Fertility.Any(e => e.ID == id);
        }
    }
}
