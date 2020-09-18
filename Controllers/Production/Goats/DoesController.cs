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
    public class DoesController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public DoesController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/Does
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doe>>> GetDoe()
        {
            return await _context.Doe.ToListAsync();
        }

        // GET: api/Does/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Doe>> GetDoe(long id)
        {
            var doe = await _context.Doe.FindAsync(id);

            if (doe == null)
            {
                return NotFound();
            }

            return doe;
        }

        // PUT: api/Does/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDoe(long id, Doe doe)
        {
            if (id != doe.ID)
            {
                return BadRequest();
            }

            _context.Entry(doe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoeExists(id))
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

        // POST: api/Does
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Doe>> PostDoe(Doe doe)
        {
            _context.Doe.Add(doe);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDoe", new { id = doe.ID }, doe);
        }

        // DELETE: api/Does/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Doe>> DeleteDoe(long id)
        {
            var doe = await _context.Doe.FindAsync(id);
            if (doe == null)
            {
                return NotFound();
            }

            _context.Doe.Remove(doe);
            await _context.SaveChangesAsync();

            return doe;
        }

        private bool DoeExists(long id)
        {
            return _context.Doe.Any(e => e.ID == id);
        }
    }
}
