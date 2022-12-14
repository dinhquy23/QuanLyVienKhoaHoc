using QLVienKhoaHoc.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVienKhoaHoc.Models
{
    public class NhanVienPhongThiNghiem : NhanVien, ITinhLuong
    {
        //  Property
        public double LuongTrongThang { get; set; }

        //Contructor
        public NhanVienPhongThiNghiem() { }
        public NhanVienPhongThiNghiem(string hoTen, int namSinh, string bangCap, double luongTrongThang)
        : base(hoTen, namSinh, bangCap)
        {
            LuongTrongThang = luongTrongThang;
        }

        //  Method
        public double LuongHangThang()
        {
            return LuongTrongThang;
        }
        public override string ToString()
        {
            return base.ToString() + $"    {string.Format("{0:#,##0}", LuongTrongThang),8}";
        }
    }
}
