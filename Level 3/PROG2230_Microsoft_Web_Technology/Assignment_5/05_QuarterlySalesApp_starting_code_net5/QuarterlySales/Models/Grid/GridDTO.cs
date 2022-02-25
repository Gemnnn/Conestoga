namespace QuarterlySales.Models
{
    public class GridDTO                   // generic
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 4;
        public string SortField { get; set; }
        public string SortDirection { get; set; } = "asc";
    }

    public class SalesGridDTO : GridDTO   // app-specific, inherits generic
    {
        //[JsonIgnore]
        public const string DefaultFilter = "all";

        public string Employee { get; set; } = DefaultFilter;
        public string Year { get; set; } = DefaultFilter;
        public string Quarter { get; set; } = DefaultFilter;
    }

}
