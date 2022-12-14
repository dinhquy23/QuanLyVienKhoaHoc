using QLVienKhoaHoc.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVienKhoaHoc.Models
{
    public class NhaKhoaHoc : NhanVien, ITinhLuong
    {
        //  Properties
        public string ChucVu { get; set; }
        public int SoBaiBao { get; set; }
        public int SoNgayCong { get; set; }
        public decimal BacLuong { get; set; }

        //  Contructor
        public NhaKhoaHoc() { }
        public NhaKhoaHoc
        (
        string hoTen,
        int namSinh,
        string bangCap,
        string chucVu,
        int soBaiBao,
        int soNgayCong,
        decimal bacLuong
        ) : base(hoTen, namSinh, bangCap)
        {
            ChucVu = chucVu;
            SoBaiBao = soBaiBao;
            SoNgayCong = soNgayCong;
            BacLuong = bacLuong;
        }

        // Method
        public double LuongHangThang()
        {
            return (double)(SoNgayCong * BacLuong);
        }
        public override string ToString()
        {
            return base.ToString() + $"    {ChucVu,8}    {SoBaiBao,5}   {SoNgayCong,5}   {BacLuong,8}";
        }
    }
}
