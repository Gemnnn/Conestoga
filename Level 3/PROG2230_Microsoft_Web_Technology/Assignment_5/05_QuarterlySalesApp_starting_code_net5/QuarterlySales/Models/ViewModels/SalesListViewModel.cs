using System;
using System.Collections.Generic;

namespace QuarterlySales.Models
{
    public class SalesListViewModel
    {
        public IEnumerable<Sales> Sales { get; set; }    
        public RouteDictionary CurrentRoute { get; set; }
        public int TotalPages { get; set; }

        // for filter drop-downs - two hard coded
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<int> Years {  
            get {
                List<int> years = new List<int>();
                int foundingYear = 1995, currentYear = DateTime.Today.Year;
                for (int yr = currentYear; yr >= foundingYear; yr--) { // make years descending (most to least recent)
                    years.Add(yr);
                }
                return years;
            }
        }
        public IEnumerable<int> Quarters {
            get {
                List<int> quarters = new List<int>();
                for (int q = 1; q <=4; q++) {
                    quarters.Add(q);
                }
                return quarters;
            }
        }
    }
}
