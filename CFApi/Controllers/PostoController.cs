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
    public class PostoController : ControllerBase
    {
        private readonly CFContext _context;

        public PostoController(CFContext context)
        {
            _context = context;
        }

        // GET: api/Posto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Posto>>> GetPosto()
        {
            return await _context.Posto.ToListAsync();
        }

        // GET: api/Posto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Posto>> GetPosto(int id)
        {
            var posto = await _context.Posto.FindAsync(id);

            if (posto == null)
            {
                return NotFound();
            }

            return posto;
        }

        // PUT: api/Posto/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPosto(int id, Posto posto)
        {
            if (id != posto.Id)
            {
                return BadRequest();
            }

            _context.Entry(posto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostoExists(id))
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

        // POST: api/Posto
        [HttpPost]
        public async Task<ActionResult<Posto>> PostPosto(Posto posto)
        {
            _context.Posto.Add(posto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPosto", new { id = posto.Id }, posto);
        }

        // DELETE: api/Posto/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Posto>> DeletePosto(int id)
        {
            var posto = await _context.Posto.FindAsync(id);
            if (posto == null)
            {
                return NotFound();
            }

            _context.Posto.Remove(posto);
            await _context.SaveChangesAsync();

            return posto;
        }

        private bool PostoExists(int id)
        {
            return _context.Posto.Any(e => e.Id == id);
        }
    }
}
