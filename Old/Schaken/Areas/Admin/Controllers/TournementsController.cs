using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Schaken.Data;

namespace Schaken.Areas._Tournement.Controllers
{
    [Area("Admin")]
    public class TournementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TournementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: _Tournement/Tournements
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tournement.ToListAsync());
        }

        // GET: _Tournement/Tournements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournement = await _context.Tournement
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tournement == null)
            {
                return NotFound();
            }

            return View(tournement);
        }

        // GET: _Tournement/Tournements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: _Tournement/Tournements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,RegistrationStartDate,RegistrationEndDate,TournementStartDate,TournementEndDate")] Tournement tournement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tournement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tournement);
        }

        // GET: _Tournement/Tournements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournement = await _context.Tournement.FindAsync(id);
            if (tournement == null)
            {
                return NotFound();
            }
            return View(tournement);
        }

        // POST: _Tournement/Tournements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,RegistrationStartDate,RegistrationEndDate,TournementStartDate,TournementEndDate")] Tournement tournement)
        {
            if (id != tournement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tournement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TournementExists(tournement.Id))
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
            return View(tournement);
        }

        // GET: _Tournement/Tournements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournement = await _context.Tournement
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tournement == null)
            {
                return NotFound();
            }

            return View(tournement);
        }

        // POST: _Tournement/Tournements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tournement = await _context.Tournement.FindAsync(id);
            _context.Tournement.Remove(tournement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TournementExists(int id)
        {
            return _context.Tournement.Any(e => e.Id == id);
        }
    }
}
