using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SG_Blazor_4.Server.Datos;
using SG_Blazor_4.Shared.Models.Psico;

namespace SG_Blazor_4.Server.Controllers
{
    [Route("api/ba7")]
    [ApiController]
    public class Ba7Controller : ControllerBase
    {
        private readonly SG_Blazor_4Context _context;

        public Ba7Controller(SG_Blazor_4Context context)
        {
            _context = context;
        }

        // GET: api/Ba7
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ba7Model>>> GetBa7Models()
        {
            return await _context.Ba7Models.ToListAsync();
        }

        // GET: api/Ba7/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ba7Model>> GetBa7Model(int id)
        {
            var ba7Model = await _context.Ba7Models.FindAsync(id);

            if (ba7Model == null)
            {
                return NotFound();
            }

            return ba7Model;
        }

        [Route("searchs")]
        public async Task<ActionResult<Ba7Model>> SearchsBa7Model(int idoa)
        {
            var ba7Model = await _context.Ba7Models.Where(c => c.IdOrdenAtencion == idoa).FirstOrDefaultAsync();
            if (ba7Model == null)
            {
                return ba7Model = new Ba7Model() { IdBa7 = 0 };
            }
            return ba7Model;
        }

        // PUT: api/Ba7/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBa7Model(int id, Ba7Model ba7Model)
        {
            if (id != ba7Model.IdBa7)
            {
                return BadRequest();
            }

            _context.Entry(ba7Model).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Ba7ModelExists(id))
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

        // POST: api/Ba7
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ba7Model>> PostBa7Model(Ba7Model ba7Model)
        {
            _context.Ba7Models.Add(ba7Model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBa7Model", new { id = ba7Model.IdBa7 }, ba7Model);
        }

        // DELETE: api/Ba7/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBa7Model(int id)
        {
            var ba7Model = await _context.Ba7Models.FindAsync(id);
            if (ba7Model == null)
            {
                return NotFound();
            }

            _context.Ba7Models.Remove(ba7Model);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Ba7ModelExists(int id)
        {
            return _context.Ba7Models.Any(e => e.IdBa7 == id);
        }
    }
}
