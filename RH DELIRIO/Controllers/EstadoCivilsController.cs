﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RH_DELIRIO.Data;
using RH_DELIRIO.Models;

namespace RH_DELIRIO
{
    public class EstadoCivilsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstadoCivilsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EstadoCivils
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstadoCivil.ToListAsync());
        }

        // GET: EstadoCivils/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoCivil = await _context.EstadoCivil
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadoCivil == null)
            {
                return NotFound();
            }

            return View(estadoCivil);
        }

        // GET: EstadoCivils/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstadoCivils/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] EstadoCivil estadoCivil)
        {
            if (ModelState.IsValid)
            {
                estadoCivil.Id = Guid.NewGuid();
                _context.Add(estadoCivil);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estadoCivil);
        }

        // GET: EstadoCivils/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoCivil = await _context.EstadoCivil.FindAsync(id);
            if (estadoCivil == null)
            {
                return NotFound();
            }
            return View(estadoCivil);
        }

        // POST: EstadoCivils/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id")] EstadoCivil estadoCivil)
        {
            if (id != estadoCivil.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadoCivil);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoCivilExists(estadoCivil.Id))
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
            return View(estadoCivil);
        }

        // GET: EstadoCivils/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoCivil = await _context.EstadoCivil
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadoCivil == null)
            {
                return NotFound();
            }

            return View(estadoCivil);
        }

        // POST: EstadoCivils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var estadoCivil = await _context.EstadoCivil.FindAsync(id);
            _context.EstadoCivil.Remove(estadoCivil);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadoCivilExists(Guid id)
        {
            return _context.EstadoCivil.Any(e => e.Id == id);
        }
    }
}
