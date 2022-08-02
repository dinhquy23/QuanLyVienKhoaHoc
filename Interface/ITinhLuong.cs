using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVienKhoaHoc.Interface
{
    /// <summary>
    /// Interface có chức năng tính tiền lươg của từng loại đối tượng theo từng tháng
    /// </summary>
    internal interface ITinhLuong
    {
        double LuongHangThang();
    }
}
