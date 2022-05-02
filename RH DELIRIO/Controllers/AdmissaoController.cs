using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RH_DELIRIO.Data;
using RH_DELIRIO.Models;

namespace RH_DELIRIO.Controllers
{
    public class AdmissaoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdmissaoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admissao
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Admissoes.Include(a => a.funcionario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admissao/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admissao = await _context.Admissoes
                .Include(a => a.funcionario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admissao == null)
            {
                return NotFound();
            }

            return View(admissao);
        }

        // GET: Admissao/Create
        public IActionResult Create()
        {
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Nome");
            return View();
        }

        // POST: Admissao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FuncionarioId,tipo,data_admissao,Id")] Admissao admissao)
        {
            if (ModelState.IsValid)
            {
                admissao.Id = Guid.NewGuid();
                _context.Add(admissao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Nome", admissao.FuncionarioId);
            return View(admissao);
        }

        // GET: Admissao/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admissao = await _context.Admissoes.FindAsync(id);
            if (admissao == null)
            {
                return NotFound();
            }
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Nome", admissao.FuncionarioId);
            return View(admissao);
        }

        // POST: Admissao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("FuncionarioId,tipo,data_admissao,Id")] Admissao admissao)
        {
            if (id != admissao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admissao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmissaoExists(admissao.Id))
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
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Nome", admissao.FuncionarioId);
            return View(admissao);
        }

        // GET: Admissao/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admissao = await _context.Admissoes
                .Include(a => a.funcionario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admissao == null)
            {
                return NotFound();
            }

            return View(admissao);
        }

        // POST: Admissao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var admissao = await _context.Admissoes.FindAsync(id);
            _context.Admissoes.Remove(admissao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdmissaoExists(Guid id)
        {
            return _context.Admissoes.Any(e => e.Id == id);
        }
    }
}
