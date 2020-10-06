using AgrixemAPI.Core.Models.Management;
using AgrixemAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Controllers.Management.Geo
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public LocationsController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/Locations/cattle/5
        [HttpGet("cattle/{farmId}")]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllCattleLocations(int farmId)
        {
            return await _context.Locations.Where(e => e.FarmID == farmId && e.AnimalType == 'C').ToListAsync();
        }
        // GET: api/Locations/goats/5
        [HttpGet("goats/{farmId}")]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllGoatsLocations(int farmId)
        {
            return await _context.Locations.Where(e => e.FarmID == farmId && e.AnimalType == 'G').ToListAsync();
        }
        // GET: api/Locations/cattle/current/5
        [HttpGet("cattle/current/{farmId}")]
        public async Task<ActionResult<IEnumerable<Location>>> GetCurrentCattleLocations(int farmId)
        {
            var Today = DateTime.UtcNow;
            return await _context.Locations
                .Where(e => e.FarmID == farmId &&
                e.AnimalType == 'C' &&
                e.Timestamp.Day == Today.Day)
                .ToListAsync();

        }
        // GET: api/Locations/goats/current/5
        [HttpGet("goats/current/{farmId}")]
        public async Task<ActionResult<IEnumerable<Location>>> GetCurrentGoatsLocations(int farmId)
        {
            var Today = DateTime.UtcNow;
            return await _context.Locations
                .Where(e => e.FarmID == farmId &&
                e.AnimalType == 'G' &&
                e.Timestamp.Day == Today.Day)
                .ToListAsync();
        }

        // GET: api/Locations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(long id)
        {
            var location = await _context.Locations.FindAsync(id);

            if (location == null)
            {
                return NotFound();
            }

            return location;
        }

        // PUT: api/Locations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocation(long id, Location location)
        {
            if (id != location.ID)
            {
                return BadRequest();
            }

            _context.Entry(location).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationExists(id))
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

        // POST: api/Locations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Location>> PostLocation(Location location)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocation", new { id = location.ID }, location);
        }

        // DELETE: api/Locations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Location>> DeleteLocation(long id)
        {
            var location = await _context.Locations.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }

            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();

            return location;
        }

        private bool LocationExists(long id)
        {
            return _context.Locations.Any(e => e.ID == id);
        }
    }
}
