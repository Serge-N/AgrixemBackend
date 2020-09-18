using AgrixemAPI.Core.DTOs.Cows;
using AgrixemAPI.Core.Models.Production.Cattle;
using AgrixemAPI.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Controllers.Production.Cows
{
    [Route("api/[controller]")]
    [ApiController]
    public class CattleController : ControllerBase
    {
        private readonly AgrixemAPIContext _context;
        private readonly IMapper _mapper;

        public CattleController(AgrixemAPIContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Cattle/farm/2
        [HttpGet("farm/{id:int}")]
        public async Task<ActionResult<IEnumerable<CattleDTO>>> GetCattle(int id)
        {
            return _mapper.Map<List<CattleDTO>>(await _context.Cattle.Where(e => e.FarmID == id).ToListAsync());
        }

        // GET: api/Cattle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CattleDTO>> GetCattle(long id)
        {
            var cattle = await _context.Cattle.FindAsync(id);

            if (cattle == null)
            {
                return NotFound();
            }

            return _mapper.Map<CattleDTO>(cattle);
        }

        // PUT: api/Cattle/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCattle(long id, CattleDTO cattle)
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
        public async Task<ActionResult<Cattle>> PostCattle(CattleDTO cattle)
        {
            _context.Cattle.Add(_mapper.Map<Cattle>(cattle));
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCattle", new { id = cattle.ID }, cattle);
        }

        // DELETE: api/Cattle/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CattleDTO>> DeleteCattle(long id)
        {
            var cattle = await _context.Cattle.FindAsync(id);
            if (cattle == null)
            {
                return NotFound();
            }

            _context.Cattle.Remove(cattle);
            await _context.SaveChangesAsync();

            return _mapper.Map<CattleDTO>(cattle);
        }

        private bool CattleExists(long id)
        {
            return _context.Cattle.Any(e => e.ID == id);
        }
    }
}
