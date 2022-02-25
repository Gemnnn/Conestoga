using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROG2230_Byounguk_Min.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace PROG2230_Byounguk_Min.Controllers
{
    public class HomeController : Controller
    {
        private readonly AssignmentContext _context;

        public HomeController(AssignmentContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
