/*
 * 
 * Program ID: Assignment1
 * 
 * Purpose: to build a basic database-driven ASP.NET Core MVC web app 
 *          as a way of getting an overview of ASP.NET Core
 * 
 * Revision History: created by Byounguk Min Sep 30, 2021
 * 
*/
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROG2230_AS1_BMin.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PROG2230_AS1_BMin.Controllers
{
    public class HomeController : Controller
    {
        private AssignmentContext context { get; set; }

        public HomeController(AssignmentContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var transactionRecords = context.TransactionRecords.Include(m => m.TransactionType)
                .OrderBy(m => m.CompanyName).ToList();
            return View(transactionRecords);

        }
    }
}
