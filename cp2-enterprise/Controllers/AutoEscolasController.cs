using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cp2_enterprise.Models;
using cp2_enterprise.Persistence;

namespace cp2_enterprise.Controllers
{
    public class AutoEscolasController : Controller
    {
        private readonly OracleContext _context;

        public AutoEscolasController(OracleContext context)
        {
            _context = context;
        }

        // GET: AutoEscolas
        public async Task<IActionResult> Index()
        {
              return _context.AutoEscolas != null ? 
                          View(await _context.AutoEscolas.ToListAsync()) :
                          Problem("Entity set 'OracleContext.AutoEscolas'  is null.");
        }

        // GET: AutoEscolas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AutoEscolas == null)
            {
                return NotFound();
            }

            var autoEscola = await _context.AutoEscolas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (autoEscola == null)
            {
                return NotFound();
            }

            return View(autoEscola);
        }

        // GET: AutoEscolas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AutoEscolas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,CEP,Logradouro,Numero,Bairro,Cidade,Estado")] AutoEscola autoEscola)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autoEscola);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(autoEscola);
        }

        // GET: AutoEscolas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AutoEscolas == null)
            {
                return NotFound();
            }

            var autoEscola = await _context.AutoEscolas.FindAsync(id);
            if (autoEscola == null)
            {
                return NotFound();
            }
            return View(autoEscola);
        }

        // POST: AutoEscolas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,CEP,Logradouro,Numero,Bairro,Cidade,Estado")] AutoEscola autoEscola)
        {
            if (id != autoEscola.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autoEscola);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutoEscolaExists(autoEscola.Id))
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
            return View(autoEscola);
        }

        // GET: AutoEscolas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AutoEscolas == null)
            {
                return NotFound();
            }

            var autoEscola = await _context.AutoEscolas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (autoEscola == null)
            {
                return NotFound();
            }

            return View(autoEscola);
        }

        // POST: AutoEscolas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AutoEscolas == null)
            {
                return Problem("Entity set 'OracleContext.AutoEscolas'  is null.");
            }
            var autoEscola = await _context.AutoEscolas.FindAsync(id);
            if (autoEscola != null)
            {
                _context.AutoEscolas.Remove(autoEscola);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutoEscolaExists(int id)
        {
          return (_context.AutoEscolas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
