using System.Collections.Generic;

namespace Moula.Common.Foundation.Paging
{
    public class PagedList<T> : IPagedList<T>
    {
        public IList<T> Results { get; set; }
        public long Total { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
    }
}