using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _25DH110487_MyStore.Models;
using PagedList; // Thư viện phân trang

namespace _25DH110487_MyStore.Models.ViewModels
{
    public class ProductSearchVM
    {
        // 1. Tiêu chí tìm kiếm theo từ khóa (tên, mô tả hoặc chủng loại sản phẩm)
        public string SearchTerm { get; set; }

        // 2. Các tiêu chí tìm kiếm theo khoảng giá
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        // 3. Thứ tự sắp xếp (tăng/giảm theo tên hoặc giá)
        public string SortOrder { get; set; }

        // 4. Thông tin phân trang (Lưu số trang hiện tại và số lượng sản phẩm mỗi trang)
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }

        // 5. Danh sách sản phẩm kết quả dưới dạng phân trang (IPagedList)
        public IPagedList<Product> Products { get; set; }
    }
}