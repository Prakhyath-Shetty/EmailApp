using System.Collections.Generic;

namespace EMailApp.Common
{
    public class PagedResultModel<T>
    {
        public int TotalRecords { get; set; }
        public List<T> Records { get; set; }
        public int TotalPages { get; set; }
    }
}
