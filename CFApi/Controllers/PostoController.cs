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
    public class PostoController : Controller
    {
        private readonly CFContext _context;

        public PostoController(CFContext context)
        {
            _context = context;
        }

        // GET: Posto
        public async Task<IActionResult> Index()
        {
            return View(await _context.Posto.ToListAsync());
        }

        // GET: Posto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posto = await _context.Posto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (posto == null)
            {
                return NotFound();
            }

            return View(posto);
        }

        // GET: Posto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Posto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Latitude,Lagitude,Id")] Posto posto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(posto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(posto);
        }

        // GET: Posto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posto = await _context.Posto.FindAsync(id);
            if (posto == null)
            {
                return NotFound();
            }
            return View(posto);
        }

        // POST: Posto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nome,Latitude,Lagitude,Id")] Posto posto)
        {
            if (id != posto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(posto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostoExists(posto.Id))
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
            return View(posto);
        }

        // GET: Posto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posto = await _context.Posto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (posto == null)
            {
                return NotFound();
            }

            return View(posto);
        }

        // POST: Posto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var posto = await _context.Posto.FindAsync(id);
            _context.Posto.Remove(posto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostoExists(int id)
        {
            return _context.Posto.Any(e => e.Id == id);
        }
    }
}
