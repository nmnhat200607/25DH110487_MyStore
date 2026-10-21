using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;

namespace _25DH110487_MyStore.Models.ViewModels
{
    public class ProductDetailsVM
    {
        public Product product { get; set; }
        public int quantity { get; set; } = 1;
        // Tính giá trị tạm thời
        public decimal estimatedValue { get; set; }

        // Các thuộc tính hỗ trợ phân trang
        public int PageNumber { get; set; }
        public int PageSize { get; set; } = 3;

        // Danh sách 8 sản phẩm cùng danh mục
        public PagedList.IPagedList<Product> RelatedProducts { get; set; }

        // Danh sách 8 sản phẩm bán chạy nhất cùng danh mục
        public PagedList.IPagedList<Product> TopProducts { get; set; }
    }
}