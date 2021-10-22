using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SG_Blazor_4.Server.Datos;
using SG_Blazor_4.Shared.Models;

namespace SG_Blazor_4.Server.Controllers
{
    [Route("api/ordenatencion")]
    [ApiController]
    public class OrdenAtencionController : ControllerBase
    {
        private readonly SG_Blazor_4Context _context;

        public OrdenAtencionController(SG_Blazor_4Context context)
        {
            _context = context;
        }

        // GET: api/OrdenAtencion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrdenAtencion>>> GetordenAtencions()
        {
            return await _context.ordenAtencions.ToListAsync();
        }

        // GET: api/OrdenAtencion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrdenAtencion>> GetOrdenAtencion(int id)
        {
            var ordenAtencion = await _context.ordenAtencions.FindAsync(id);

            if (ordenAtencion == null)
            {
                return NotFound();
            }

            return ordenAtencion;
        }

        // PUT: api/OrdenAtencion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrdenAtencion(int id, OrdenAtencion ordenAtencion)
        {
            if (id != ordenAtencion.IdOrdenAtencion)
            {
                return BadRequest();
            }

            _context.Entry(ordenAtencion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdenAtencionExists(id))
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

        // POST: api/OrdenAtencion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrdenAtencion>> PostOrdenAtencion(OrdenAtencion ordenAtencion)
        {
            _context.ordenAtencions.Add(ordenAtencion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrdenAtencion", new { id = ordenAtencion.IdOrdenAtencion }, ordenAtencion);
        }

        // DELETE: api/OrdenAtencion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrdenAtencion(int id)
        {
            var ordenAtencion = await _context.ordenAtencions.FindAsync(id);
            if (ordenAtencion == null)
            {
                return NotFound();
            }

            _context.ordenAtencions.Remove(ordenAtencion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrdenAtencionExists(int id)
        {
            return _context.ordenAtencions.Any(e => e.IdOrdenAtencion == id);
        }
    }
}
