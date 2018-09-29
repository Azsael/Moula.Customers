using System.Collections.Generic;

namespace Moula.Common.Foundation.Paging
{
    public interface IPagedList<T>
    {
        IList<T> Results { get; set; }

        long Total { get; set; }
        int Take { get; set; }
        int Skip { get; set; }
    }
}