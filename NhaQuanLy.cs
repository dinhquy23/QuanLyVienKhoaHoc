﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVienKhoaHoc
{
    /*
     * họ tên, năm sinh, bằng cấp, chức vụ, số ngày công trong tháng, bậc lương 
     */
    public class NhaQuanLy : NhanVien, ITinhLuong
    {
        //  Properties
        public string ChucVu { get; set; }
        public int SoNgayCong { get; set; }
        public decimal BacLuong { get; set; }
        
        //Contructor
        public NhaQuanLy() { }
        public NhaQuanLy
        (
        string hoTen, 
        int namSinh, 
        string bangCap, 
        string chucVu, 
        int soNgayCong, 
        decimal bacLuong
        )
        :base(hoTen,namSinh,bangCap)
        {
            ChucVu = chucVu;
            SoNgayCong = soNgayCong;
            BacLuong = bacLuong;
        }
        
        //  Method
        public double LuongHangThang()
        {
            return (double)(SoNgayCong * BacLuong);
        }
    }
}
