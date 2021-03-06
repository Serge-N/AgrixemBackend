﻿using AgrixemAPI.Core.Models.Production.Cattle;
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
    public class TreatmentsController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public TreatmentsController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/Treatments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Treatment>>> GetTreatment()
        {
            return await _context.Treatment.ToListAsync();
        }

        // GET: api/Treatments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Treatment>> GetTreatment(long id)
        {
            var treatment = await _context.Treatment.FindAsync(id);

            if (treatment == null)
            {
                return NotFound();
            }

            return treatment;
        }

        // PUT: api/Treatments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTreatment(long id, Treatment treatment)
        {
            if (id != treatment.ID)
            {
                return BadRequest();
            }

            _context.Entry(treatment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TreatmentExists(id))
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

        // POST: api/Treatments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Treatment>> PostTreatment(Treatment treatment)
        {
            _context.Treatment.Add(treatment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTreatment", new { id = treatment.ID }, treatment);
        }

        // DELETE: api/Treatments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Treatment>> DeleteTreatment(long id)
        {
            var treatment = await _context.Treatment.FindAsync(id);
            if (treatment == null)
            {
                return NotFound();
            }

            _context.Treatment.Remove(treatment);
            await _context.SaveChangesAsync();

            return treatment;
        }

        private bool TreatmentExists(long id)
        {
            return _context.Treatment.Any(e => e.ID == id);
        }
    }
}
