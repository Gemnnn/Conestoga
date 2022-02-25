using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROG2230_AS1_BMin.Models;

namespace PROG2230_AS1_BMin.Controllers
{
    public class TransactionRecordController : Controller
    {
        
        private AssignmentContext context { get; set; }

        public TransactionRecordController(AssignmentContext ctx)
        {
            context = ctx;
        }

        // Get : Add transaction record
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.TransactionTypes = context.TransactionTypes.OrderBy(g => g.TransactionTypeId).ToList();
            return View("Edit", new TransactionRecord());
        }

        // Get : Edit transaction records
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.TransactionTypes = context.TransactionTypes.OrderBy(g => g.TransactionTypeId).ToList();
            var transactionRecord = context.TransactionRecords.Find(id);
            return View(transactionRecord);
        }
        
        // Post : Edit transaction records
        [HttpPost]
        public IActionResult Edit(TransactionRecord transactionRecord)
        {
            if (ModelState.IsValid)
            {
                if (transactionRecord.TransactionRecordId == 0)
                {
                    context.TransactionRecords.Add(transactionRecord);
                }
                else
                {
                    context.TransactionRecords.Update(transactionRecord);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action =
                    (transactionRecord.TransactionRecordId == 0) ? "Add" : "Edit";
                ViewBag.TransactionTypes = context.TransactionTypes.OrderBy(g => g.TransactionTypeId).ToList();
                return View(transactionRecord);
            }
        }

        // GET : Delete transaction records
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var transactionRecord = context.TransactionRecords.Find(id);
            return View(transactionRecord);
        }

        // POST : Delete transaction records
        [HttpPost]
        public IActionResult Delete(TransactionRecord transactionRecord)
        {
            context.TransactionRecords.Remove(transactionRecord);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
