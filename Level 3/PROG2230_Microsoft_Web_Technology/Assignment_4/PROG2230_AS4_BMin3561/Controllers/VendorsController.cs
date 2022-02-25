/*
 * Program ID : Assignment 4
 *
 * Revision History : Created by Byounguk Min Nov 25, 2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROG2230_AS4_BMin3561.Models.Generated;

namespace PROG2230_AS4_BMin3561.Controllers
{
    public class VendorsController : Controller
    {
        private readonly apContext _context;

        public VendorsController(apContext context)
        {
            _context = context;
        }

        // GET: Vendors
        public async Task<IActionResult> Index(string start)
        {
            var apContext = _context.Vendors.Include(v => v.DefaultAccountNumberNavigation)
                .Include(v => v.DefaultTerms)
                .OrderBy(v => v.VendorName);


            if (start == null)
            {
                ViewData["start"] = "A";
            }
            else
            {
                ViewData["start"] = start;
            }

            ViewBag.Message = TempData["undo"];


            return View(apContext);
        }

        // GET: Vendors/Details/5
        public async Task<IActionResult> Invoice(int? vendorId, int? invoiceId)
        {
            if (vendorId == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendors.FindAsync(vendorId);
            if (vendor == null)
            {
                return NotFound();
            }
            var term = await _context.Terms.FindAsync(vendor.DefaultTermsId);
            if (term == null)
            {
                return NotFound();
            }

            var invoices = _context.Invoices.Where(i => i.VendorId == vendor.VendorId);
            //var invoiceLineItems = _context.InvoiceLineItems;
            if (invoices.Count() == 0)
            {
                return RedirectToAction(nameof(Index));
            }
            if (invoiceId == null)
            {
                List<Invoice> tempInvoices = invoices.ToList<Invoice>();
                invoiceId = tempInvoices[0].InvoiceId;
            }
            
            var invoiceLineItems = _context.InvoiceLineItems.Where(i => i.InvoiceId == invoiceId);

            ViewModel viewModel = new ViewModel();
            viewModel.ViewVendor = vendor;
            viewModel.ViewTerm = term;
            viewModel.ViewInvoices = invoices;
            viewModel.ViewInvoiceLineItems = invoiceLineItems;
            viewModel.ViewInvoiceLineItem = new InvoiceLineItem();

            ViewData["GroupName"] = vendor.getStart(vendor.VendorName);

            Invoice invoice = new Invoice();
            foreach (var item in invoices)
            {
                if (item.InvoiceId == invoiceId)
                {
                    invoice = item;
                }
            }
            ViewData["InvoiceNumber"] = invoice.InvoiceNumber;

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Invoice(InvoiceLineItem invoiceLineItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(invoiceLineItem);
                await _context.SaveChangesAsync();

            }
                return RedirectToAction(nameof(Index));
        }

        // GET: Vendors/Create
        public IActionResult Create()
        {
            ViewData["DefaultAccountNumber"] = new SelectList(_context.GeneralLedgerAccounts, "AccountNumber", "AccountNumber");
            ViewData["DefaultTermsId"] = new SelectList(_context.Terms, "TermsId", "TermsDescription");
            return View();
        }

        // POST: Vendors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VendorId,VendorName,VendorAddress1,VendorAddress2,VendorCity,VendorState,VendorZipCode,VendorPhone,VendorContactLastName,VendorContactFirstName,VendorContactEmail,DefaultTermsId,DefaultAccountNumber,IsDeleted")] Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DefaultAccountNumber"] = new SelectList(_context.GeneralLedgerAccounts, "AccountNumber", "AccountNumber", vendor.DefaultAccountNumber);
            ViewData["DefaultTermsId"] = new SelectList(_context.Terms, "TermsId", "TermsDescription", vendor.DefaultTermsId);
            return View(vendor);
        }

        // GET: Vendors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendors.FindAsync(id);
            if (vendor == null)
            {
                return NotFound();
            }
            ViewData["DefaultAccountNumber"] = new SelectList(_context.GeneralLedgerAccounts, "AccountNumber", "AccountNumber", vendor.DefaultAccountNumber);
            ViewData["DefaultTermsId"] = new SelectList(_context.Terms, "TermsId", "TermsDescription", vendor.DefaultTermsId);
            return View(vendor);
        }

        // POST: Vendors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VendorId,VendorName,VendorAddress1,VendorAddress2,VendorCity,VendorState,VendorZipCode,VendorPhone,VendorContactLastName,VendorContactFirstName,VendorContactEmail,DefaultTermsId,DefaultAccountNumber,IsDeleted")] Vendor vendor)
        {
            if (id != vendor.VendorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendorExists(vendor.VendorId))
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
            ViewData["DefaultAccountNumber"] = new SelectList(_context.GeneralLedgerAccounts, "AccountNumber", "AccountNumber", vendor.DefaultAccountNumber);
            ViewData["DefaultTermsId"] = new SelectList(_context.Terms, "TermsId", "TermsDescription", vendor.DefaultTermsId);
            return View(vendor);
        }

        // GET: Vendors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendors
                .Include(v => v.DefaultAccountNumberNavigation)
                .Include(v => v.DefaultTerms)
                .FirstOrDefaultAsync(m => m.VendorId == id);
            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        // POST: Vendors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendor = await _context.Vendors.FindAsync(id);

            vendor.IsDeleted = true;

            _context.Update(vendor);
            await _context.SaveChangesAsync();

            TempData["undo"] = " The vendor " + vendor.VendorName + " was deleted.";

            return RedirectToAction(nameof(Index));
        }

        private bool VendorExists(int id)
        {
            return _context.Vendors.Any(e => e.VendorId == id);
        }



    }
}
