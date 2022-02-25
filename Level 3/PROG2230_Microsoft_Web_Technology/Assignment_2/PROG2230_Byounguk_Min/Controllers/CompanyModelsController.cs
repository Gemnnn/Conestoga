using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROG2230_Byounguk_Min.Models;

namespace PROG2230_Byounguk_Min.Controllers
{
    public class CompanyModelsController : Controller
    {
        private readonly AssignmentContext _context;

        public CompanyModelsController(AssignmentContext context)
        {
            _context = context;
        }

        // GET: CompanyModels
        public async Task<IActionResult> Index()
        {
            var assignmentContext = _context.CompanyModels;
            return View(await assignmentContext.ToListAsync());
        }

        public async Task<IActionResult> Transactions(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assignmentContext = await _context.TransactionRecords.Include(m => m.TransactionType).Include(m => m.CompanyModel).FirstOrDefaultAsync(m => m.CompanyId == id);

            if (assignmentContext == null)
            {
                return NotFound();
            }

            return View(assignmentContext);
        }

        // GET: CompanyModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyModel = await _context.CompanyModels
                
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyModel == null)
            {
                return NotFound();
            }

            return View(companyModel);
        }

        // GET: CompanyModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName,CompanyAddress,Ticker")] CompanyModel companyModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyModel);
                await _context.SaveChangesAsync();
                TempData["message"] = "<span class='alert alert-success'>Save Successful</span>";

                return RedirectToAction(nameof(Index));
            }
            TempData["message"] = "<span class='alert alert-danger'>Save Fail</span>";
            return View(companyModel);
        }

        // GET: CompanyModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyModel = await _context.CompanyModels.FindAsync(id);
            if (companyModel == null)
            {
                return NotFound();
            }
            return View(companyModel);
        }

        // POST: CompanyModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompanyId,CompanyName,CompanyAddress,Ticker")] CompanyModel companyModel)
        {
            if (id != companyModel.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyModelExists(companyModel.CompanyId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["message"] = "<span class='alert alert-success'>Save Successful</span>";
                return RedirectToAction(nameof(Index));
            }

            TempData["message"] = "<span class='alert alert-danger'>Save Fail</span>";
            return View(companyModel);
        }

        // GET: CompanyModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyModel = await _context.CompanyModels
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyModel == null)
            {
                return NotFound();
            }

            return View(companyModel);
        }

        // POST: CompanyModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var companyModel = await _context.CompanyModels.FindAsync(id);
            _context.CompanyModels.Remove(companyModel);
            await _context.SaveChangesAsync();
            TempData["message"] = "<span class='alert alert-danger'>Deleted " + companyModel.CompanyName + "'s information record.</span>";

            return RedirectToAction(nameof(Index));
        }

        private bool CompanyModelExists(int id)
        {
            return _context.CompanyModels.Any(e => e.CompanyId == id);
        }
    }
}
