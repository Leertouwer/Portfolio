using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Schaak.Areas.Admin.Models;
using SchaakData;

namespace Schaak.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class TournementsController : Controller
    {
        private readonly ApplContext _context;

        public TournementsController(ApplContext context)
        {
            _context = context;
        }

        // GET: Admin/Tournements
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tournement.ToListAsync());
        }

        // GET: Admin/Tournements/Details/5
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

        // GET: Admin/Tournements/Create
        public IActionResult Create()
        {
            var model = new TournementViewModel();
            return View(model);
        }

        // POST: Admin/Tournements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,RegistrationStartDate,RegistrationEndDate,TournementStartDate,TournementEndDate")] TournementViewModel model)
        {
            var tournement = new Tournement();
            if (ModelState.IsValid)
            {
                tournement.Id = model.Id;
                tournement.Name = model.Name;
                tournement.RegistrationEndDate = model.RegistrationEndDate;
                tournement.RegistrationStartDate = model.RegistrationStartDate;
                tournement.TournementEndDate = model.TournementEndDate;
                tournement.TournementStartDate = model.TournementStartDate;
                _context.Add(tournement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tournement);
        }

        // GET: Admin/Tournements/Edit/5
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

        // POST: Admin/Tournements/Edit/5
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

        // GET: Admin/Tournements/Delete/5
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

        // POST: Admin/Tournements/Delete/5
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
