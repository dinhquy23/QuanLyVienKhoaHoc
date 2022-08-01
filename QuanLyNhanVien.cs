using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVienKhoaHoc
{
    public class QuanLyNhanVien
    {
        private static List<NhanVien> _dsNhanVien;
        static QuanLyNhanVien()
        {
            _dsNhanVien = new List<NhanVien>()
            {
                new NhaKhoaHoc("Dinh Quy", 1999, "Ky su", "Fresher", 2, 22, 0.7m),
                new NhaKhoaHoc("Pham Tuan", 1999, "Ky su", "Intern", 3, 21, 0.7m),
                new NhanVienPhongThiNghiem("Huy Hoang", 2000, "Cao Dang", 7000000),
                new NhaQuanLy("Tien Dung", 1998, "Cao Dang", "Abc", 21, 0.9m)
            };
        }
        //List<NhanVien> dsNhanVien = new List<NhanVien>()
        //{
        //    new NhaKhoaHoc("Dinh Quy", 1999, "Ky su", "Fresher", 2, 22, 0.7m),
        //    new NhaKhoaHoc("Pham Tuan", 1999, "Ky su", "Intern", 3, 21, 0.7m),
        //    new NhanVienPhongThiNghiem("Huy Hoang", 2000, "Cao Dang", 7000000),
        //    new NhaQuanLy("Tien Dung", 1998, "Cao Dang", "Abc", 21, 0.9m)
        //};

        public void AddNhaKhoaHoc()
        {
            Console.Write($"Nhap ten: ");
            string ten = Console.ReadLine();
            Console.Write($"Nhap nam sinh: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write($"Bang cap: ");
            string bangCap = Console.ReadLine();
            Console.Write($"Chuc vu: ");
            string chucVu = Console.ReadLine();
            Console.Write($"So bai bao: ");
            int soBaiBao = int.Parse(Console.ReadLine());
            Console.Write($"Ngay cong: ");
            int ngayCong = int.Parse(Console.ReadLine());
            Console.Write($"Bac luong: ");
            decimal bacLuong = decimal.Parse(Console.ReadLine());
            NhaKhoaHoc nhaKhoaHoc = new NhaKhoaHoc(ten, tuoi, bangCap, chucVu, soBaiBao, ngayCong, bacLuong);
            _dsNhanVien.Add(nhaKhoaHoc);
        }
        public void AddNhaQuanLy()
        {
            Console.Write($"Nhap ten: ");
            string ten = Console.ReadLine();
            Console.Write($"Nhap nam sinh: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write($"Bang cap: ");
            string bangCap = Console.ReadLine();
            Console.Write($"Chuc vu: ");
            string chucVu = Console.ReadLine();
            Console.Write($"Ngay cong: ");
            int ngayCong = int.Parse(Console.ReadLine());
            Console.Write($"Bac luong: ");
            decimal bacLuong = decimal.Parse(Console.ReadLine());
            NhaQuanLy nhaQuanLy = new NhaQuanLy(ten, tuoi, bangCap, chucVu, ngayCong, bacLuong);
            _dsNhanVien.Add(nhaQuanLy);
        }
        public void AddNhanVienPhongThiNghiem()
        {
            Console.Write($"Nhap ten: ");
            string ten = Console.ReadLine();
            Console.Write($"Nhap nam sinh: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write($"Bang cap: ");
            string bangCap = Console.ReadLine();
            Console.Write($"Luong trong thang: ");
            double luongTrongThang = double.Parse(Console.ReadLine());
            NhanVienPhongThiNghiem nhanVienPhongThiNghiem = new NhanVienPhongThiNghiem(ten, tuoi, bangCap, luongTrongThang);
            _dsNhanVien.Add(nhanVienPhongThiNghiem);
        }

        public void TongLuongTungDoiTuong()
        {
            double Tong1 = 0, Tong2 = 0, Tong3 = 0;
            foreach (var item in _dsNhanVien)
            {
                if (item is NhanVienPhongThiNghiem)
                {
                    NhanVienPhongThiNghiem a = (NhanVienPhongThiNghiem)item;
                    Tong1 += a.LuongTrongThang;
                }
                else if (item is NhaKhoaHoc)
                {
                    NhaKhoaHoc b = (NhaKhoaHoc)item;
                    Tong2 += b.LuongHangThang();
                }
                else if (item is NhaQuanLy)
                {
                    NhaQuanLy c = (NhaQuanLy)item;
                    Tong3 += c.LuongHangThang();
                }
            }
            Console.Write($"\nLuong cua nhan vien phong thi nghiem trong thang la: {string.Format("{0:#,##0.00}", Tong1)}");
            Console.Write($"\nLuong cua nha khoa hoc trong thang la: {string.Format("{0:#,##0.00}", Tong2 * 1000000)}");
            Console.Write($"\nLuong cua nha quan ly trong thang la: {string.Format("{0:#,##0.00}", Tong3 * 1000000)}\n");
        }
        public void HienThiNhanVien()
        {
            Console.WriteLine("Danh sach tung loai nhan vien");
            Console.WriteLine("\n======== Nha khoa hoc ========");
            foreach (var item in _dsNhanVien)
            {
                if (item is NhaKhoaHoc)
                {
                    NhaKhoaHoc a = (NhaKhoaHoc)item;
                    Console.WriteLine($"{a.HoTen}   {a.NamSinh}    {a.BangCap}  {a.ChucVu}  {a.SoBaiBao}    {a.SoNgayCong}  {a.BacLuong}");
                }
            }
            Console.WriteLine("\n======== Nha quan ly ========");
            foreach (var item in _dsNhanVien)
            {
                if (item is NhaQuanLy)
                {
                    NhaQuanLy a = (NhaQuanLy)item;
                    Console.WriteLine($"{a.HoTen}   {a.NamSinh}    {a.BangCap}  {a.ChucVu}    {a.SoNgayCong}  {a.BacLuong}");
                }
            }
            Console.WriteLine("\n======== Nhan vien phong thi nghiem ========");
            foreach (var item in _dsNhanVien)
            {
                if (item is NhanVienPhongThiNghiem)
                {
                    NhanVienPhongThiNghiem a = (NhanVienPhongThiNghiem)item;
                    Console.WriteLine($"{a.HoTen}   {a.NamSinh}    {a.BangCap}  {a.LuongTrongThang}");
                }
            }
        }
    }
}