using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Employee_ManagementSystem.Data;
using Employee_ManagementSystem.Models;

namespace Employee_ManagementSystem.Controllers
{
    public class BiosController : Controller
    {
        private readonly ApplicationDbcontext _context;

        public BiosController(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: Bios
        public async Task<IActionResult> Index()
        {
            var applicationDbcontext = _context.BioData.Include(b => b.Employee);
            return View(await applicationDbcontext.ToListAsync());
        }

        // GET: Bios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bio = await _context.BioData
                .Include(b => b.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bio == null)
            {
                return NotFound();
            }

            return View(bio);
        }

        // GET: Bios/Create
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName");
            return View();
        }

        // POST: Bios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EmployeeId,DateOfBirth,LGA,NextOfKin,StateOfOrigin,DateOfResumption,SocialHandles,Remarks")] Bio bio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName", bio.EmployeeId);
            return View(bio);
        }

        // GET: Bios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bio = await _context.BioData.FindAsync(id);
            if (bio == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName", bio.EmployeeId);
            return View(bio);
        }

        // POST: Bios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EmployeeId,DateOfBirth,LGA,NextOfKin,StateOfOrigin,DateOfResumption,SocialHandles,Remarks")] Bio bio)
        {
            if (id != bio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BioExists(bio.Id))
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
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName", bio.EmployeeId);
            return View(bio);
        }

        // GET: Bios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bio = await _context.BioData
                .Include(b => b.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bio == null)
            {
                return NotFound();
            }

            return View(bio);
        }

        // POST: Bios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bio = await _context.BioData.FindAsync(id);
            if (bio != null)
            {
                _context.BioData.Remove(bio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BioExists(int id)
        {
            return _context.BioData.Any(e => e.Id == id);
        }
    }
}
