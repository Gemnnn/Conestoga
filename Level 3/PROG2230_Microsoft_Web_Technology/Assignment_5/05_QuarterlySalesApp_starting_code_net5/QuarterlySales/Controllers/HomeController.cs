using Microsoft.AspNetCore.Mvc;
using QuarterlySales.Models;

namespace QuarterlySales.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork data { get; set; }
        public HomeController(SalesContext ctx) => data = new UnitOfWork(ctx);

        [HttpGet]
        public ViewResult Index(SalesGridDTO vals)
        {
            string defaultSort = nameof(Sales.Year);
            var builder = new SalesGridBuilder(HttpContext.Session, vals, defaultSort);

            var options = new SalesQueryOptions {
                Includes = "Employee",
                OrderByDirection = builder.CurrentRoute.SortDirection,
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize
            };
            options.SortFilter(builder);

            var vm = new SalesListViewModel {
                Sales = data.Sales.List(options),  
                Employees = data.Employees.List(new QueryOptions<Employee> { 
                    OrderBy = e => e.Firstname
                }),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(data.Sales.Count)
            };
            return View(vm);
        }

        [HttpPost]
        public RedirectToActionResult Filter(string[] filter, bool clear = false)
        {
            var builder = new SalesGridBuilder(HttpContext.Session);

            if (clear) {
                builder.ClearFilterSegments();
            }
            else {  // get employee so can add slug if needed
                var employee = data.Employees.Get(filter[0].ToInt());
                builder.LoadFilterSegments(filter, employee);
            }

            return RedirectToAction("Index", builder.CurrentRoute);
        }

        [HttpGet]
        public RedirectToActionResult Clear()
        {
            /* because MVC 'remembers' previous route segments if new ones aren't set, you can have
             * a situation where a link with only a controller and action method set still includes
             * all the paging, sorting, and filtering segments from an earlier GET request. One way
             * to clear out those previous segments is to pass a blank anonymous object to the 
             * RedirectToAction() method, as shown here. This action method is called by the Home link
             * in the layout page so that the user always goes to a 'fresh' instance of the home page.
             */
            return RedirectToAction("Index", new { });
        }
    }
}
