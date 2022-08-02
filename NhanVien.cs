using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVienKhoaHoc
{
    public abstract class NhanVien
    {
        //  Properties
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string BangCap { get; set; }

        //  Contructor
        public NhanVien() { }
        public NhanVien(string hoTen, int namSinh, string bangCap)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            BangCap = bangCap;
        }

        // method
        public override string ToString()
        {
            return $"{HoTen,10}   {NamSinh,5}   {BangCap,8}";
        }
    }
}
