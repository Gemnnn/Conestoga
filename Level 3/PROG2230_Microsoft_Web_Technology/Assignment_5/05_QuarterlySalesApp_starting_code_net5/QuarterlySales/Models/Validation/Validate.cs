using System.Linq;

namespace QuarterlySales.Models
{
    /**************************************************************************************** 
     * static methods called by both client-side Remote validation (see ValidationController)
     * and server-side backup (see EmployeeController and SalesController)
     ****************************************************************************************/

    public static class Validate
    {
        public static string CheckEmployee(Repository<Employee> data, Employee emp)
        {
            var options = new QueryOptions<Employee> {
                Where = e => e.Firstname == emp.Firstname &&
                e.Lastname == emp.Lastname &&
                e.DOB == emp.DOB
            };
            var employee = data.Get(options);

            if (employee == null) {
                return "";
            }
            else {
                return $"{employee.Fullname} (DOB: {employee.DOB?.ToShortDateString()}) is already in the database.";
            }
        }

        public static string CheckManagerEmployeeMatch(Repository<Employee> data, Employee emp)
        {
            var manager = data.Get(emp.ManagerId);
            if (manager != null &&
                manager.Firstname == emp.Firstname &&
                manager.Lastname == emp.Lastname &&
                manager.DOB == emp.DOB)
            {
                return $"Manager and employee can't be the same person.";
            }
            else {
                return "";
            }    
        }

        public static string CheckSales(UnitOfWork data, Sales sl)
        {
            var options = new QueryOptions<Sales> {
                Where = s => s.Quarter == sl.Quarter &&
                s.Year == sl.Year &&
                s.EmployeeId == sl.EmployeeId
            };
            var sales = data.Sales.Get(options);
            
            if (sales == null) {
                return "";
            }
            else {
                // get complete employee data so can include full name in validation message
                var emp = data.Employees.Get(sl.EmployeeId);
                return $"Sales for {emp.Fullname} for {sl.Year} Q{sl.Quarter} are already in the database.";
            }
        }
    }
}
