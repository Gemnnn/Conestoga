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
    public class TransactionRecordsController : Controller
    {
        private readonly AssignmentContext _context;

        public TransactionRecordsController(AssignmentContext context)
        {
            _context = context;
        }

        // GET: TransactionRecords
        public async Task<IActionResult> Index(int order)
        {
            var assignmentContext = _context.TransactionRecords.Include(m => m.TransactionType).Include(m => m.CompanyModel).OrderBy(m => m.CompanyModel.CompanyName);
            ViewBag.order = 2;

            if (order == 2)
            {
                assignmentContext = _context.TransactionRecords.Include(m => m.TransactionType).Include(m => m.CompanyModel).OrderByDescending(m => m.CompanyModel.CompanyName);
                ViewBag.order = 1;
            }
            return View(await assignmentContext.ToListAsync());
        }

        // GET: TransactionRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionRecord = await _context.TransactionRecords
                .Include(t => t.TransactionType)
                .FirstOrDefaultAsync(m => m.TransactionRecordId == id);
            if (transactionRecord == null)
            {
                return NotFound();
            }

            return View(transactionRecord);
        }

        // GET: TransactionRecords/Create
        public IActionResult Create()
        {
            ViewData["TransactionType"] = new SelectList(_context.TransactionTypes, "TransactionTypeId", "Name");
            ViewData["Company"] = new SelectList(_context.CompanyModels, "CompanyId", "CompanyName");
            return View();
        }

        // POST: TransactionRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionRecordId,Quantity,SharePrice,TransactionTypeId,CompanyId")] TransactionRecord transactionRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transactionRecord);
                await _context.SaveChangesAsync();
                TempData["message"] = "<span class='alert alert-success'>Save Successful</span>";
                return RedirectToAction(nameof(Index));
            }

            TempData["message"] = "<span class='alert alert-danger'>Save Fail</span>";
            ViewData["TransactionTypeId"] = new SelectList(_context.TransactionTypes, "TransactionTypeId", "TransactionTypeId", transactionRecord.TransactionTypeId);
            return View(transactionRecord);
        }

        // GET: TransactionRecords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionRecord = await _context.TransactionRecords.FindAsync(id);
            if (transactionRecord == null)
            {
                return NotFound();
            }
            ViewData["TransactionType"] = new SelectList(_context.TransactionTypes, "TransactionTypeId", "Name", transactionRecord.TransactionTypeId);
            ViewData["CompanyModel"] = new SelectList(_context.CompanyModels, "CompanyId", "CompanyName", transactionRecord.TransactionTypeId);
            return View(transactionRecord);
        }

        // POST: TransactionRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionRecordId,Quantity,SharePrice,TransactionTypeId,CompanyId")] TransactionRecord transactionRecord)
        {
            if (id != transactionRecord.TransactionRecordId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transactionRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionRecordExists(transactionRecord.TransactionRecordId))
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
            ViewData["TransactionTypeId"] = new SelectList(_context.TransactionTypes, "TransactionTypeId", "TransactionTypeId", transactionRecord.TransactionTypeId);
            return View(transactionRecord);
        }

        // GET: TransactionRecords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionRecord = await _context.TransactionRecords
                .Include(t => t.TransactionType)
                .FirstOrDefaultAsync(m => m.TransactionRecordId == id);
            if (transactionRecord == null)
            {
                return NotFound();
            }

            return View(transactionRecord);
        }

        // POST: TransactionRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transactionRecord = await _context.TransactionRecords.FindAsync(id);
            _context.TransactionRecords.Remove(transactionRecord);
            await _context.SaveChangesAsync();

            TempData["message"] = "<span class='alert alert-danger'>Deleted " + transactionRecord.CompanyModel.CompanyName + "'s transactions record.</span>";
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionRecordExists(int id)
        {
            return _context.TransactionRecords.Any(e => e.TransactionRecordId == id);
        }
    }
}
