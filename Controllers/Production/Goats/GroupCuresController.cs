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
    public class GroupCuresController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;

        public GroupCuresController(AgrixemAPIContext context)
        {
            _context = context;
        }

        // GET: api/GroupCures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupCure>>> GetGroupCure()
        {
            return await _context.GroupCure.ToListAsync();
        }

        // GET: api/GroupCures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GroupCure>> GetGroupCure(long id)
        {
            var groupCure = await _context.GroupCure.FindAsync(id);

            if (groupCure == null)
            {
                return NotFound();
            }

            return groupCure;
        }

        // PUT: api/GroupCures/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroupCure(long id, GroupCure groupCure)
        {
            if (id != groupCure.ID)
            {
                return BadRequest();
            }

            _context.Entry(groupCure).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupCureExists(id))
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

        // POST: api/GroupCures
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GroupCure>> PostGroupCure(GroupCure groupCure)
        {
            _context.GroupCure.Add(groupCure);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGroupCure", new { id = groupCure.ID }, groupCure);
        }

        // DELETE: api/GroupCures/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GroupCure>> DeleteGroupCure(long id)
        {
            var groupCure = await _context.GroupCure.FindAsync(id);
            if (groupCure == null)
            {
                return NotFound();
            }

            _context.GroupCure.Remove(groupCure);
            await _context.SaveChangesAsync();

            return groupCure;
        }

        private bool GroupCureExists(long id)
        {
            return _context.GroupCure.Any(e => e.ID == id);
        }
    }
}
