using System;
using Microsoft.AspNetCore.Http;

namespace QuarterlySales.Models
{
    public class GridBuilder  // generic
    {
        private const string RouteKey = "currentroute";

        protected RouteDictionary routes { get; set; }
        private ISession session { get; set; }

        // this constructor used when just need to get route data from session
        public GridBuilder(ISession sess)
        {
            session = sess;
            routes = session.GetObject<RouteDictionary>(RouteKey) ?? new RouteDictionary();
        }
        // this constructor used when need to store paging-sorting route segments
        public GridBuilder(ISession sess, GridDTO values, string defaultSortField)
        {
            session = sess;

            routes = new RouteDictionary(); // clear previous route segment values
            routes.PageNumber = values.PageNumber;
            routes.PageSize = values.PageSize;
            routes.SortField = values.SortField ?? defaultSortField;
            routes.SortDirection = values.SortDirection;

            SaveRouteSegments();
        }

        public void SaveRouteSegments() => session.SetObject<RouteDictionary>(RouteKey, routes);

        public int GetTotalPages(int count) {
            int size = routes.PageSize;
            return (count + size - 1) / size;
        }

        public RouteDictionary CurrentRoute => routes;
    }

}
