using System;
using Microsoft.AspNetCore.Mvc;
using QuarterlySales.Models;

namespace QuarterlySales.Controllers
{
    public class ValidationController : Controller
    {
        private UnitOfWork data { get; set; }
        public ValidationController(SalesContext ctx) => new UnitOfWork(ctx);

        public JsonResult CheckEmployee(DateTime dob, string firstname, string lastname)
        {
            var employee = new Employee { 
                Firstname = firstname, Lastname = lastname, DOB = dob
            };
            string msg = Validate.CheckEmployee(data.Employees, employee);
            if (string.IsNullOrEmpty(msg))
                return Json(true);
            else
                return Json(msg);
        }

        public JsonResult CheckManager(int managerId, string firstname, string lastname, DateTime dob)
        {
            var employee = new Employee
            {
                Firstname = firstname,
                Lastname = lastname,
                DOB = dob,
                ManagerId = managerId
            };
            string msg = Validate.CheckManagerEmployeeMatch(data.Employees, employee);
            if (string.IsNullOrEmpty(msg))
                return Json(true);
            else
                return Json(msg);
        }

        public JsonResult CheckSales(int quarter, int year, int employeeId)
        {
            var sales = new Sales {
                Quarter = quarter, Year = year, EmployeeId = employeeId
            };
            string msg = Validate.CheckSales(data, sales);
            if (string.IsNullOrEmpty(msg))
                return Json(true);
            else
                return Json(msg);
        }

    }
}