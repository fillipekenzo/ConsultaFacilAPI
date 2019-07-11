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
    public class MedicoPostoController : ControllerBase
    {
        private readonly CFContext _context;

        public MedicoPostoController(CFContext context)
        {
            _context = context;
        }

        // GET: api/MedicoPosto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedicoPosto>>> GetMedicoPosto()
        {
            return await _context.MedicoPosto.ToListAsync();
        }

        // GET: api/MedicoPosto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MedicoPosto>> GetMedicoPosto(int id)
        {
            var medicoPosto = await _context.MedicoPosto.FindAsync(id);

            if (medicoPosto == null)
            {
                return NotFound();
            }

            return medicoPosto;
        }

        // PUT: api/MedicoPosto/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicoPosto(int id, MedicoPosto medicoPosto)
        {
            if (id != medicoPosto.Id)
            {
                return BadRequest();
            }

            _context.Entry(medicoPosto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicoPostoExists(id))
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

        // POST: api/MedicoPosto
        [HttpPost]
        public async Task<ActionResult<MedicoPosto>> PostMedicoPosto(MedicoPosto medicoPosto)
        {
            _context.MedicoPosto.Add(medicoPosto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedicoPosto", new { id = medicoPosto.Id }, medicoPosto);
        }

        // DELETE: api/MedicoPosto/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MedicoPosto>> DeleteMedicoPosto(int id)
        {
            var medicoPosto = await _context.MedicoPosto.FindAsync(id);
            if (medicoPosto == null)
            {
                return NotFound();
            }

            _context.MedicoPosto.Remove(medicoPosto);
            await _context.SaveChangesAsync();

            return medicoPosto;
        }

        private bool MedicoPostoExists(int id)
        {
            return _context.MedicoPosto.Any(e => e.Id == id);
        }
    }
}
