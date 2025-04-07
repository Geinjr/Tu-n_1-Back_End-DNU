using System;
using System.Collections.Generic;

namespace bai_8
{
    // ===== Lớp SinhVien =====
    public class SinhVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string Lop { get; set; }
        public string MaSV { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập lớp: ");
            Lop = Console.ReadLine();

            Console.Write("Nhập mã số sinh viên: ");
            MaSV = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Lớp: {Lop}, Mã SV: {MaSV}");
        }
    }

    // ===== Lớp TheMuon =====
    public class TheMuon
    {
        public string SoPhieuMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public string SoHieuSach { get; set; }
        public SinhVien SinhVien { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập số phiếu mượn: ");
            SoPhieuMuon = Console.ReadLine();

            Console.Write("Nhập ngày mượn (dd/MM/yyyy): ");
            NgayMuon = DateTime.Parse(Console.ReadLine() ?? "01/01/2000");

            Console.Write("Nhập hạn trả (dd/MM/yyyy): ");
            HanTra = DateTime.Parse(Console.ReadLine() ?? "01/01/2000");

            Console.Write("Nhập số hiệu sách: ");
            SoHieuSach = Console.ReadLine();

            SinhVien = new SinhVien();
            Console.WriteLine("=== Nhập thông tin sinh viên ===");
            SinhVien.Nhap();
        }

        public void HienThi()
        {
            Console.WriteLine($"\nPhiếu mượn: {SoPhieuMuon}, Ngày mượn: {NgayMuon.ToShortDateString()}, Hạn trả: {HanTra.ToShortDateString()}, Số hiệu sách: {SoHieuSach}");
            SinhVien.HienThi();
        }
    }

    // ===== Quản lý danh sách thẻ mượn =====
    public class QuanLyTheMuon
    {
        public List<TheMuon> DanhSachMuon = new List<TheMuon>();

        public void NhapDanhSach()
        {
            Console.Write("Nhập số lượng sinh viên mượn sách: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n-- Nhập thông tin sinh viên thứ {i + 1} --");
                TheMuon tm = new TheMuon();
                tm.Nhap();
                DanhSachMuon.Add(tm);
            }
        }

        public void HienThiTatCa()
        {
            Console.WriteLine("\n== Danh sách tất cả thẻ mượn ==");
            foreach (var tm in DanhSachMuon)
            {
                tm.HienThi();
            }
        }

        public void TimKiemTheoMaSV(string maSV)
        {
            bool timThay = false;
            Console.WriteLine($"\n== Kết quả tìm kiếm theo mã SV \"{maSV}\" ==");
            foreach (var tm in DanhSachMuon)
            {
                if (tm.SinhVien.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase))
                {
                    tm.HienThi();
                    timThay = true;
                }
            }

            if (!timThay)
                Console.WriteLine("Không tìm thấy sinh viên.");
        }

        public void HienThiQuaHan()
        {
            Console.WriteLine("\n== Danh sách sinh viên đã quá hạn trả sách ==");
            DateTime today = DateTime.Today;
            bool coSinhVienQuaHan = false;

            foreach (var tm in DanhSachMuon)
            {
                if (tm.HanTra < today)
                {
                    tm.HienThi();
                    coSinhVienQuaHan = true;
                }
            }

            if (!coSinhVienQuaHan)
                Console.WriteLine("Không có sinh viên nào quá hạn.");
        }
    }
}

