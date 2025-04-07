using System;
using System.Collections.Generic;

namespace bai_6
{
    // ===== Lớp Nguoi: Quản lý thông tin cá nhân =====
    class Nguoi
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public int NamSinh { get; set; }
        public string QueQuan { get; set; }
        public string GioiTinh { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập tuổi: ");
            Tuoi = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập quê quán: ");
            QueQuan = Console.ReadLine();

            Console.Write("Nhập giới tính (Nam/Nữ): ");
            GioiTinh = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Quê quán: {QueQuan}, Giới tính: {GioiTinh}");
        }
    }

    // ===== Lớp HSHocSinh: Hồ sơ học sinh =====
    class HSHocSinh
    {
        public Nguoi ThongTinCaNhan { get; set; } = new Nguoi();
        public string Lop { get; set; }
        public string KhoaHoc { get; set; }
        public string KyHoc { get; set; }

        public void Nhap()
        {
            ThongTinCaNhan.Nhap();

            Console.Write("Nhập lớp: ");
            Lop = Console.ReadLine();

            Console.Write("Nhập khoá học: ");
            KhoaHoc = Console.ReadLine();

            Console.Write("Nhập kỳ học: ");
            KyHoc = Console.ReadLine();
        }

        public void HienThi()
        {
            ThongTinCaNhan.HienThi();
            Console.WriteLine($"Lớp: {Lop}, Khoá học: {KhoaHoc}, Kỳ học: {KyHoc}");
        }

        public bool LaNuVaSinhNam1985()
        {
            return ThongTinCaNhan.GioiTinh.ToLower() == "nữ" && ThongTinCaNhan.NamSinh == 1985;
        }

        public bool TimTheoQueQuan(string qq)
        {
            return ThongTinCaNhan.QueQuan.ToLower().Contains(qq.ToLower());
        }
    }

    // ===== Lớp TruongTHPT: Quản lý danh sách học sinh =====
    class TruongTHPT
    {
        private List<HSHocSinh> danhSachHocSinh = new List<HSHocSinh>();

        public void NhapDanhSach()
        {
            Console.Write("Nhập số học sinh: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập hồ sơ học sinh thứ {i + 1}:");
                HSHocSinh hs = new HSHocSinh();
                hs.Nhap();
                danhSachHocSinh.Add(hs);
            }
        }

        public void HienThiNu1985()
        {
            Console.WriteLine("\n==> Học sinh nữ sinh năm 1985:");
            bool timThay = false;
            foreach (var hs in danhSachHocSinh)
            {
                if (hs.LaNuVaSinhNam1985())
                {
                    hs.HienThi();
                    Console.WriteLine("---------------------");
                    timThay = true;
                }
            }
            if (!timThay)
                Console.WriteLine("Không có học sinh nữ sinh năm 1985.");
        }

        public void TimKiemTheoQueQuan(string qq)
        {
            Console.WriteLine($"\n==> Kết quả tìm kiếm theo quê quán \"{qq}\":");
            bool timThay = false;
            foreach (var hs in danhSachHocSinh)
            {
                if (hs.TimTheoQueQuan(qq))
                {
                    hs.HienThi();
                    Console.WriteLine("---------------------");
                    timThay = true;
                }
            }
            if (!timThay)
                Console.WriteLine("Không có học sinh nào từ quê quán này.");
        }
    }
}
