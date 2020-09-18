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
    public class MarketsController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public MarketsController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/Markets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Market>>> GetMarket()
        {
            return await _context.Market.ToListAsync();
        }

        // GET: api/Markets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Market>> GetMarket(long id)
        {
            var market = await _context.Market.FindAsync(id);

            if (market == null)
            {
                return NotFound();
            }

            return market;
        }

        // PUT: api/Markets/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMarket(long id, Market market)
        {
            if (id != market.ID)
            {
                return BadRequest();
            }

            _context.Entry(market).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarketExists(id))
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

        // POST: api/Markets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Market>> PostMarket(Market market)
        {
            _context.Market.Add(market);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMarket", new { id = market.ID }, market);
        }

        // DELETE: api/Markets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Market>> DeleteMarket(long id)
        {
            var market = await _context.Market.FindAsync(id);
            if (market == null)
            {
                return NotFound();
            }

            _context.Market.Remove(market);
            await _context.SaveChangesAsync();

            return market;
        }

        private bool MarketExists(long id)
        {
            return _context.Market.Any(e => e.ID == id);
        }
    }
}
