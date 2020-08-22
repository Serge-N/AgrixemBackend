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
    public class VaccinationsController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public VaccinationsController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/Vaccinations
        [HttpGet("{farmId:int}")]
        public async Task<ActionResult<IEnumerable<Vaccination>>> GetVaccination(int farmId)
        {
            return await _context.Vaccination.Where(e => e.FarmID == farmId).ToListAsync();
        }

        // GET: api/Vaccinations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vaccination>> GetVaccination(long id)
        {
            var vaccination = await _context.Vaccination.FindAsync(id);

            if (vaccination == null)
            {
                return NotFound();
            }

            return vaccination;
        }

        // PUT: api/Vaccinations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVaccination(long id, Vaccination vaccination)
        {
            if (id != vaccination.ID)
            {
                return BadRequest();
            }

            _context.Entry(vaccination).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VaccinationExists(id))
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

        // POST: api/Vaccinations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Vaccination>> PostVaccination(Vaccination vaccination)
        {
            _context.Vaccination.Add(vaccination);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVaccination", new { id = vaccination.ID }, vaccination);
        }

        // DELETE: api/Vaccinations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vaccination>> DeleteVaccination(long id)
        {
            var vaccination = await _context.Vaccination.FindAsync(id);
            if (vaccination == null)
            {
                return NotFound();
            }

            _context.Vaccination.Remove(vaccination);
            await _context.SaveChangesAsync();

            return vaccination;
        }

        private bool VaccinationExists(long id)
        {
            return _context.Vaccination.Any(e => e.ID == id);
        }
    }
}
