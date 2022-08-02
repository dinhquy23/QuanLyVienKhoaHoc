using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVienKhoaHoc
{
    public class NhanVienPhongThiNghiem:NhanVien,ITinhLuong
    {
        public double LuongTrongThang { get; set; }
        public NhanVienPhongThiNghiem() { }
        public NhanVienPhongThiNghiem(string hoTen, int namSinh,string bangCap, double luongTrongThang):base(hoTen,namSinh,bangCap)
        {
            LuongTrongThang = luongTrongThang;
        }

        public double LuongHangThang()
        {
            return LuongTrongThang;
        }
    }
}
