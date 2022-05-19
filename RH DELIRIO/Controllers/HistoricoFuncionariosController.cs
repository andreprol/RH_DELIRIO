using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RH_DELIRIO.Data;
using RH_DELIRIO.Models;

namespace RH_DELIRIO.Controllers
{
    [Authorize]
    public class HistoricoFuncionariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HistoricoFuncionariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HistoricoFuncionarios
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.HistoricosFuncionarios.Include(h => h.funcionario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: HistoricoFuncionarios/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoFuncionario = await _context.HistoricosFuncionarios
                .Include(h => h.funcionario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicoFuncionario == null)
            {
                return NotFound();
            }

            return View(historicoFuncionario);
        }

        // GET: HistoricoFuncionarios/Create
        public IActionResult Create()
        {
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Nome");
            return View();
        }

        // POST: HistoricoFuncionarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FuncionarioId,data,descricao,Id")] HistoricoFuncionario historicoFuncionario)
        {
            if (ModelState.IsValid)
            {
                historicoFuncionario.Id = Guid.NewGuid();
                _context.Add(historicoFuncionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Nome", historicoFuncionario.FuncionarioId);
            return View(historicoFuncionario);
        }

        // GET: HistoricoFuncionarios/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoFuncionario = await _context.HistoricosFuncionarios.FindAsync(id);
            if (historicoFuncionario == null)
            {
                return NotFound();
            }
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Nome", historicoFuncionario.FuncionarioId);
            return View(historicoFuncionario);
        }

        // POST: HistoricoFuncionarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("FuncionarioId,data,descricao,Id")] HistoricoFuncionario historicoFuncionario)
        {
            if (id != historicoFuncionario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historicoFuncionario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistoricoFuncionarioExists(historicoFuncionario.Id))
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
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Nome", historicoFuncionario.FuncionarioId);
            return View(historicoFuncionario);
        }

        // GET: HistoricoFuncionarios/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoFuncionario = await _context.HistoricosFuncionarios
                .Include(h => h.funcionario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicoFuncionario == null)
            {
                return NotFound();
            }

            return View(historicoFuncionario);
        }

        // POST: HistoricoFuncionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var historicoFuncionario = await _context.HistoricosFuncionarios.FindAsync(id);
            _context.HistoricosFuncionarios.Remove(historicoFuncionario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricoFuncionarioExists(Guid id)
        {
            return _context.HistoricosFuncionarios.Any(e => e.Id == id);
        }
    }
}
