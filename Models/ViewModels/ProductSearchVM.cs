using System.Collections.Generic;
using PagedList;

namespace _25DH110487_MyStore.Models.ViewModel
{
    public class ProductSearchVM
    {
        public string SearchTerm { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public string SortOrder { get; set; }
        public PagedList.IPagedList<Product> Products { get; set; }
    }
}