using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgrixemAPI.Core.Models;
using AgrixemAPI.Data;

namespace AgrixemAPI.Controllers.Production.Cows
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedigreesController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public PedigreesController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/Pedigrees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedigree>>> GetPedigree()
        {
            return await _context.Pedigree.ToListAsync();
        }

        // GET: api/Pedigrees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pedigree>> GetPedigree(long id)
        {
            var pedigrees = await _context.Pedigree.ToListAsync();
            var pedigree = pedigrees.FirstOrDefault(e => e.CattleFK == id);

            if (pedigree == null)
            {
                return NotFound();
            }

            return pedigree;
        }

        // PUT: api/Pedigrees/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedigree(long id, Pedigree pedigree)
        {
            if (id != pedigree.CattleID)
            {
                return BadRequest();
            }

            _context.Entry(pedigree).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedigreeExists(id))
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

        // POST: api/Pedigrees
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pedigree>> PostPedigree(Pedigree pedigree)
        {
            _context.Pedigree.Add(pedigree);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPedigree", new { id = pedigree.CattleID }, pedigree);
        }

        // DELETE: api/Pedigrees/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pedigree>> DeletePedigree(long id)
        {
            var pedigree = await _context.Pedigree.FindAsync(id);
            if (pedigree == null)
            {
                return NotFound();
            }

            _context.Pedigree.Remove(pedigree);
            await _context.SaveChangesAsync();

            return pedigree;
        }

        private bool PedigreeExists(long id)
        {
            return _context.Pedigree.Any(e => e.CattleID == id);
        }
    }
}
