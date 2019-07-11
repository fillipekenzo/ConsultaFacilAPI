using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CFApi.Model;

namespace CFApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoConsultaController : ControllerBase
    {
        private readonly CFContext _context;

        public TipoConsultaController(CFContext context)
        {
            _context = context;
        }

        // GET: api/TipoConsulta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoConsulta>>> GetTipoConsulta()
        {
            return await _context.TipoConsulta.ToListAsync();
        }

        // GET: api/TipoConsulta/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoConsulta>> GetTipoConsulta(int id)
        {
            var tipoConsulta = await _context.TipoConsulta.FindAsync(id);

            if (tipoConsulta == null)
            {
                return NotFound();
            }

            return tipoConsulta;
        }

        // PUT: api/TipoConsulta/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoConsulta(int id, TipoConsulta tipoConsulta)
        {
            if (id != tipoConsulta.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoConsulta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoConsultaExists(id))
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

        // POST: api/TipoConsulta
        [HttpPost]
        public async Task<ActionResult<TipoConsulta>> PostTipoConsulta(TipoConsulta tipoConsulta)
        {
            _context.TipoConsulta.Add(tipoConsulta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoConsulta", new { id = tipoConsulta.Id }, tipoConsulta);
        }

        // DELETE: api/TipoConsulta/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoConsulta>> DeleteTipoConsulta(int id)
        {
            var tipoConsulta = await _context.TipoConsulta.FindAsync(id);
            if (tipoConsulta == null)
            {
                return NotFound();
            }

            _context.TipoConsulta.Remove(tipoConsulta);
            await _context.SaveChangesAsync();

            return tipoConsulta;
        }

        private bool TipoConsultaExists(int id)
        {
            return _context.TipoConsulta.Any(e => e.Id == id);
        }
    }
}
