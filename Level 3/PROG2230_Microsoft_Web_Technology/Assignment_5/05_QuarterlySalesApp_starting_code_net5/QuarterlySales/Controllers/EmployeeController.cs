using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuarterlySales.Models;

namespace QuarterlySales.Controllers
{
    public class EmployeeController : Controller
    {
        private Repository<Employee> data { get; set; }
        public EmployeeController(SalesContext ctx) => data = new Repository<Employee>(ctx);

        public IActionResult Index() => RedirectToAction("Index", "Home");

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Employees = data.List(new QueryOptions<Employee> { OrderBy = e => e.Firstname });
            return View();
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            // server side checks for remote validation
            string msg = Validate.CheckEmployee(data, employee);
            if (!string.IsNullOrEmpty(msg)) { 
                ModelState.AddModelError(nameof(Employee.DOB), msg);
            }
            msg = Validate.CheckManagerEmployeeMatch(data, employee);
            if (!string.IsNullOrEmpty(msg)) { 
                ModelState.AddModelError(nameof(Employee.ManagerId), msg);
            }

            if (ModelState.IsValid) {
                data.Insert(employee);
                data.Save();
                TempData["message"] = $"Employee {employee.Fullname} added";
                return RedirectToAction("Index", "Home");
            }
            else {
                ViewBag.Employees = data.List(new QueryOptions<Employee> { OrderBy = e => e.Firstname });
                return View();
            }
        }
    }
}