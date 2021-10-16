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
    [Route("api/lsb_50")]
    [ApiController]
    public class LSB_50Controller : ControllerBase
    {
        private readonly SG_Blazor_4Context _context;

        public LSB_50Controller(SG_Blazor_4Context context)
        {
            _context = context;
        }

        // GET: api/LSB_50
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LSB_50Model>>> GetLSB_50Model()
        {
            return await _context.LSB_50Model.ToListAsync();
        }

        // GET: api/LSB_50/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LSB_50Model>> GetLSB_50Model(int id)
        {
            var lSB_50Model = await _context.LSB_50Model.FindAsync(id);

            if (lSB_50Model == null)
            {
                return NotFound();
            }

            return lSB_50Model;
        }

        // PUT: api/LSB_50/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLSB_50Model(int id, LSB_50Model lSB_50Model)
        {
            if (id != lSB_50Model.IdLSB_50)
            {
                return BadRequest();
            }

            _context.Entry(lSB_50Model).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LSB_50ModelExists(id))
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

        // POST: api/LSB_50
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LSB_50Model>> PostLSB_50Model(LSB_50Model lSB_50Model)
        {
            _context.LSB_50Model.Add(lSB_50Model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLSB_50Model", new { id = lSB_50Model.IdLSB_50 }, lSB_50Model);
        }

        // DELETE: api/LSB_50/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLSB_50Model(int id)
        {
            var lSB_50Model = await _context.LSB_50Model.FindAsync(id);
            if (lSB_50Model == null)
            {
                return NotFound();
            }

            _context.LSB_50Model.Remove(lSB_50Model);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LSB_50ModelExists(int id)
        {
            return _context.LSB_50Model.Any(e => e.IdLSB_50 == id);
        }
    }
}
