using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuarterlySales.Models;

namespace QuarterlySales.Controllers
{
    public class SalesController : Controller
    {
        private UnitOfWork data { get; set; }
        public SalesController(SalesContext ctx) => data = new UnitOfWork(ctx);

        public IActionResult Index() => RedirectToAction("Index", "Home");

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Employees = data.Employees.List(new QueryOptions<Employee> { OrderBy = e => e.Firstname });
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(Sales sales)
        {
            // server side check for remote validation
            string msg = Validate.CheckSales(data, sales);
            if (!string.IsNullOrEmpty(msg)) { 
                ModelState.AddModelError(nameof(sales.EmployeeId), msg);
            }

            if (ModelState.IsValid)
            {
                data.Sales.Insert(sales);
                data.Save();
                TempData["message"] = "Sales added";
                return RedirectToAction("Index", "Home");
            }
            else 
            {
                ViewBag.Employees = data.Employees.List(new QueryOptions<Employee> { OrderBy = e => e.Firstname });
                return View();
            }
            
        }
    }
}