using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImtahanLast.ViewModels
{
    public class PaginationVM<T>
    {
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public List<T> items { get; set; }

    }
}
