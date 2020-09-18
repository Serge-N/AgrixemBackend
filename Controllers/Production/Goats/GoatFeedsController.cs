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
    public class GoatFeedsController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public GoatFeedsController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/GoatFeeds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GoatFeed>>> GetGoatFeed()
        {
            return await _context.GoatFeed.ToListAsync();
        }

        // GET: api/GoatFeeds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GoatFeed>> GetGoatFeed(long id)
        {
            var goatFeed = await _context.GoatFeed.FindAsync(id);

            if (goatFeed == null)
            {
                return NotFound();
            }

            return goatFeed;
        }

        // PUT: api/GoatFeeds/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGoatFeed(long id, GoatFeed goatFeed)
        {
            if (id != goatFeed.ID)
            {
                return BadRequest();
            }

            _context.Entry(goatFeed).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GoatFeedExists(id))
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

        // POST: api/GoatFeeds
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GoatFeed>> PostGoatFeed(GoatFeed goatFeed)
        {
            _context.GoatFeed.Add(goatFeed);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGoatFeed", new { id = goatFeed.ID }, goatFeed);
        }

        // DELETE: api/GoatFeeds/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GoatFeed>> DeleteGoatFeed(long id)
        {
            var goatFeed = await _context.GoatFeed.FindAsync(id);
            if (goatFeed == null)
            {
                return NotFound();
            }

            _context.GoatFeed.Remove(goatFeed);
            await _context.SaveChangesAsync();

            return goatFeed;
        }

        private bool GoatFeedExists(long id)
        {
            return _context.GoatFeed.Any(e => e.ID == id);
        }
    }
}
