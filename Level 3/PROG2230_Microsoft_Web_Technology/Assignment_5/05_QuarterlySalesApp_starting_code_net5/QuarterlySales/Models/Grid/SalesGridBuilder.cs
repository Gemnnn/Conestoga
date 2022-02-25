using Microsoft.AspNetCore.Http;

namespace QuarterlySales.Models
{
    public class SalesGridBuilder : GridBuilder  // app-specific, inherits generic class
    {
        // this constructor gets route data from session state
        public SalesGridBuilder(ISession sess) : base(sess) { }

        // this constructor stores filtering route segments, as 
        // well as paging and sorting segments stored by the base constructor
        public SalesGridBuilder(ISession sess, SalesGridDTO values,
            string defaultSortField) : base(sess, values, defaultSortField)
        {
            routes.EmployeeFilter = values.Employee;
            routes.YearFilter = values.Year;
            routes.QuarterFilter = values.Quarter;
        }

        public void LoadFilterSegments(string[] filter, Employee employee)
        {
            if (employee == null) {
                routes.EmployeeFilter = filter[0];
            }
            else {
                routes.EmployeeFilter = filter[0] + "-" + employee.Fullname.Slug();
            }
            routes.YearFilter = filter[1];
            routes.QuarterFilter = filter[2];
        }
        public void ClearFilterSegments() => routes.ClearFilters();

        // filter flags 
        string def = SalesGridDTO.DefaultFilter;        // static DTO property
        public bool IsFilterByEmployee => routes.EmployeeFilter != def;
        public bool IsFilterByYear => routes.YearFilter != def;
        public bool IsFilterByQuarter => routes.QuarterFilter != def;

        // sort flags 
        public bool IsSortByQuarter =>
            routes.SortField.EqualsNoCase(nameof(Sales.Quarter));
        public bool IsSortByYear =>
            routes.SortField.EqualsNoCase(nameof(Sales.Year));
        public bool IsSortByEmployee =>
            routes.SortField.EqualsNoCase(nameof(Employee));
        public bool IsSortByAmount =>
            routes.SortField.EqualsNoCase(nameof(Sales.Amount));
    }

}
