using System;
using System.Collections.Generic;

namespace bai_7
{
    // Lớp Nguoi: Quản lý thông tin cá nhân
    public class Nguoi
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string QueQuan { get; set; }
        public string CMND { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhập quê quán: ");
            QueQuan = Console.ReadLine();
            Console.Write("Nhập CMND: ");
            CMND = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Quê quán: {QueQuan}, CMND: {CMND}");
        }
    }

    // Lớp CBGV: Thông tin cán bộ giáo viên
    public class CBGV : Nguoi
    {
        public double LuongCung { get; set; }
        public double Thuong { get; set; }
        public double Phat { get; set; }

        public double TinhLuong()
        {
            return LuongCung + Thuong - Phat;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập lương cứng: ");
            LuongCung = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhập tiền thưởng: ");
            Thuong = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhập tiền phạt: ");
            Phat = double.Parse(Console.ReadLine() ?? "0");
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Lương cứng: {LuongCung}, Thưởng: {Thuong}, Phạt: {Phat}, Lương thực lĩnh: {TinhLuong()}");
        }
    }
}
