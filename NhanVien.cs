using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVienKhoaHoc
{
    public class NhanVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string BangCap { get; set; }
        public NhanVien() { }
        public NhanVien(string hoTen, int namSinh, string bangCap)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            BangCap = bangCap;
        }
    }
}
