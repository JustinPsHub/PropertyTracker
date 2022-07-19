using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PropertyTracker.Data;
using PropertyTracker.Models;

namespace PropertyTracker.Controllers
{
    public class RenovationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RenovationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Renovations
        public async Task<IActionResult> Index()
        {
              return _context.Renovations != null ? 
                          View(await _context.Renovations.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Renovations'  is null.");
        }

        // GET: Renovations/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Renovations == null)
            {
                return NotFound();
            }

            var renovation = await _context.Renovations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (renovation == null)
            {
                return NotFound();
            }

            return View(renovation);
        }

        // GET: Renovations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Renovations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BuildingId,Category,Purpose,ImprovementType,ImprovementDescription,EstimatedCost,ActualCost,StartDate,EndDate,Contractor,PropertyId,Quantity,Price")] Renovation renovation)
        {
            if (ModelState.IsValid)
            {
                renovation.Id = Guid.NewGuid();
                _context.Add(renovation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(renovation);
        }

        // GET: Renovations/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Renovations == null)
            {
                return NotFound();
            }

            var renovation = await _context.Renovations.FindAsync(id);
            if (renovation == null)
            {
                return NotFound();
            }
            return View(renovation);
        }

        // POST: Renovations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,BuildingId,Category,Purpose,ImprovementType,ImprovementDescription,EstimatedCost,ActualCost,StartDate,EndDate,Contractor,PropertyId,Quantity,Price")] Renovation renovation)
        {
            if (id != renovation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(renovation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RenovationExists(renovation.Id))
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
            return View(renovation);
        }

        // GET: Renovations/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Renovations == null)
            {
                return NotFound();
            }

            var renovation = await _context.Renovations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (renovation == null)
            {
                return NotFound();
            }

            return View(renovation);
        }

        // POST: Renovations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Renovations == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Renovations'  is null.");
            }
            var renovation = await _context.Renovations.FindAsync(id);
            if (renovation != null)
            {
                _context.Renovations.Remove(renovation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RenovationExists(Guid id)
        {
          return (_context.Renovations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
