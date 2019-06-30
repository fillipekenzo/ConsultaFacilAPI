using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CFApi.Model;

namespace CFApi.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly CFContext _context;

        public ConsultaController(CFContext context)
        {
            _context = context;
        }

        // GET: Consulta
        public async Task<IActionResult> Index()
        {
            var cFContext = _context.Consulta.Include(c => c.Medico).Include(c => c.Posto).Include(c => c.TipoConsulta).Include(c => c.Usuario);
            return View(await cFContext.ToListAsync());
        }

        // GET: Consulta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consulta
                .Include(c => c.Medico)
                .Include(c => c.Posto)
                .Include(c => c.TipoConsulta)
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // GET: Consulta/Create
        public IActionResult Create()
        {
            ViewData["MedicoId"] = new SelectList(_context.Medico, "Id", "Id");
            ViewData["PostoId"] = new SelectList(_context.Posto, "Id", "Id");
            ViewData["TipoConsultaId"] = new SelectList(_context.TipoConsulta, "Id", "Id");
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id");
            return View();
        }

        // POST: Consulta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsuarioId,PostoId,MedicoId,TipoConsultaId,DataHora,Id")] Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consulta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MedicoId"] = new SelectList(_context.Medico, "Id", "Id", consulta.MedicoId);
            ViewData["PostoId"] = new SelectList(_context.Posto, "Id", "Id", consulta.PostoId);
            ViewData["TipoConsultaId"] = new SelectList(_context.TipoConsulta, "Id", "Id", consulta.TipoConsultaId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id", consulta.UsuarioId);
            return View(consulta);
        }

        // GET: Consulta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consulta.FindAsync(id);
            if (consulta == null)
            {
                return NotFound();
            }
            ViewData["MedicoId"] = new SelectList(_context.Medico, "Id", "Id", consulta.MedicoId);
            ViewData["PostoId"] = new SelectList(_context.Posto, "Id", "Id", consulta.PostoId);
            ViewData["TipoConsultaId"] = new SelectList(_context.TipoConsulta, "Id", "Id", consulta.TipoConsultaId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id", consulta.UsuarioId);
            return View(consulta);
        }

        // POST: Consulta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsuarioId,PostoId,MedicoId,TipoConsultaId,DataHora,Id")] Consulta consulta)
        {
            if (id != consulta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consulta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultaExists(consulta.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MedicoId"] = new SelectList(_context.Medico, "Id", "Id", consulta.MedicoId);
            ViewData["PostoId"] = new SelectList(_context.Posto, "Id", "Id", consulta.PostoId);
            ViewData["TipoConsultaId"] = new SelectList(_context.TipoConsulta, "Id", "Id", consulta.TipoConsultaId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id", consulta.UsuarioId);
            return View(consulta);
        }

        // GET: Consulta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consulta
                .Include(c => c.Medico)
                .Include(c => c.Posto)
                .Include(c => c.TipoConsulta)
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // POST: Consulta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consulta = await _context.Consulta.FindAsync(id);
            _context.Consulta.Remove(consulta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultaExists(int id)
        {
            return _context.Consulta.Any(e => e.Id == id);
        }
    }
}
