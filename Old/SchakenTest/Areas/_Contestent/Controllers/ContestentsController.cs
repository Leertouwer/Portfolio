using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Schaken.Data;

namespace Schaken.Areas._Contestent.Controllers
{
    [Area("_Contestent")]
    public class ContestentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContestentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: _Contestent/Contestents
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contestent.ToListAsync());
        }

        // GET: _Contestent/Contestents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contestent = await _context.Contestent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contestent == null)
            {
                return NotFound();
            }

            return View(contestent);
        }

        // GET: _Contestent/Contestents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: _Contestent/Contestents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TournementId,AspNetUsersId,EnlistTime")] Contestent contestent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contestent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contestent);
        }

        // GET: _Contestent/Contestents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contestent = await _context.Contestent.FindAsync(id);
            if (contestent == null)
            {
                return NotFound();
            }
            return View(contestent);
        }

        // POST: _Contestent/Contestents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TournementId,AspNetUsersId,EnlistTime")] Contestent contestent)
        {
            if (id != contestent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contestent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContestentExists(contestent.Id))
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
            return View(contestent);
        }

        // GET: _Contestent/Contestents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contestent = await _context.Contestent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contestent == null)
            {
                return NotFound();
            }

            return View(contestent);
        }

        // POST: _Contestent/Contestents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contestent = await _context.Contestent.FindAsync(id);
            _context.Contestent.Remove(contestent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContestentExists(int id)
        {
            return _context.Contestent.Any(e => e.Id == id);
        }
    }
}
