using System;
using System.Collections.Generic;

namespace bai_4
{
    // ===== Lớp Nguoi =====
    class Nguoi
    {
        public string CMND { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public int NamSinh { get; set; }
        public string NgheNghiep { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập số CMND: ");
            CMND = Console.ReadLine();

            Console.Write("Nhập tuổi: ");
            Tuoi = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập nghề nghiệp: ");
            NgheNghiep = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, CMND: {CMND}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Nghề nghiệp: {NgheNghiep}");
        }
    }

    // ===== Lớp HoDan =====
    class HoDan
    {
        public int SoNha { get; set; }
        public int SoThanhVien { get; set; }
        public List<Nguoi> ThanhVien { get; set; } = new List<Nguoi>();

        public void Nhap()
        {
            Console.Write("Nhập số nhà: ");
            SoNha = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập số thành viên: ");
            SoThanhVien = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < SoThanhVien; i++)
            {
                Console.WriteLine($"\nNhập thông tin thành viên thứ {i + 1}:");
                Nguoi nguoi = new Nguoi();
                nguoi.Nhap();
                ThanhVien.Add(nguoi);
            }
        }

        public void HienThi()
        {
            Console.WriteLine($"\n==> Hộ dân số nhà {SoNha}, gồm {SoThanhVien} thành viên:");
            foreach (var nguoi in ThanhVien)
            {
                nguoi.HienThi();
            }
        }

        public bool TimTheoTen(string hoTen)
        {
            foreach (var nguoi in ThanhVien)
            {
                if (nguoi.HoTen.ToLower().Contains(hoTen.ToLower()))
                    return true;
            }
            return false;
        }
    }

    // ===== Lớp KhuPho =====
    class KhuPho
    {
        public List<HoDan> danhSachHoDan = new List<HoDan>();

        public void NhapDanhSachHoDan()
        {
            Console.Write("Nhập số hộ dân trong khu phố: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin hộ dân thứ {i + 1}:");
                HoDan hoDan = new HoDan();
                hoDan.Nhap();
                danhSachHoDan.Add(hoDan);
            }
        }

        public void HienThiTatCa()
        {
            Console.WriteLine("\n==> Danh sách toàn bộ hộ dân:");
            foreach (var hoDan in danhSachHoDan)
            {
                hoDan.HienThi();
            }
        }

        public void TimKiemTheoTen(string ten)
        {
            Console.WriteLine($"\n==> Kết quả tìm kiếm theo tên \"{ten}\":");
            bool timThay = false;
            foreach (var hoDan in danhSachHoDan)
            {
                if (hoDan.TimTheoTen(ten))
                {
                    hoDan.HienThi();
                    timThay = true;
                }
            }

            if (!timThay)
                Console.WriteLine("Không tìm thấy hộ dân nào có tên phù hợp.");
        }

        public void TimKiemTheoSoNha(int soNha)
        {
            Console.WriteLine($"\n==> Kết quả tìm kiếm theo số nhà {soNha}:");
            bool timThay = false;
            foreach (var hoDan in danhSachHoDan)
            {
                if (hoDan.SoNha == soNha)
                {
                    hoDan.HienThi();
                    timThay = true;
                }
            }

            if (!timThay)
                Console.WriteLine("Không tìm thấy hộ dân nào có số nhà này.");
        }
    }