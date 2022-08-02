using System;
using System.Collections.Generic;

namespace QLVienKhoaHoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string luaChon = "";
            QuanLyNhanVien manager = new QuanLyNhanVien();
            do
            {
                Console.Write($"=========MENU=========");
                Console.Write($"\n1. Them nha khoa hoc");
                Console.Write($"\n2. Them nha quan ly");
                Console.Write($"\n3. Them nhan vien phong thi nghiem");
                Console.Write($"\n4. Hien thi nhan vien theo loai");
                Console.Write($"\n5. Hien thi luong cua nhan vien");
                Console.Write($"\n0. Thoat");
                Console.Write($"\nLua chon cua ban: ");
                luaChon = Console.ReadLine();
                Console.Write($"\n\n--------------------------------");

                switch(luaChon)
                {
                    case "1":
                        manager.AddNhaKhoaHoc();
                        break;
                    case "2":
                        manager.AddNhaQuanLy();
                        break;
                    case "3":
                        manager.AddNhanVienPhongThiNghiem();
                        break;
                    case "4":
                        manager.HienThiNhanVien();
                        break;
                    case "5":
                        manager.TongLuongTungDoiTuong();
                        break;
                    case "0":
                        break;
                    default:
                        Console.Write($"Lua chon sai, hay nhap lai!");
                        break;
                }
                Console.WriteLine("\n--------------------------------");
            }
            while (luaChon != "0");
        }
    }
}
