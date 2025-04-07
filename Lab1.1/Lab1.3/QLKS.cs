using System;
using System.Collections.Generic;

namespace bai_5
{
    // ===== Lớp Nguoi: Quản lý thông tin cá nhân =====
    class Nguoi
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string CMND { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập số CMND: ");
            CMND = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, CMND: {CMND}");
        }
    }

    // ===== Lớp KhachThue: Quản lý thông tin khách thuê phòng =====
    class KhachThue
    {
        public Nguoi ThongTinCaNhan { get; set; } = new Nguoi();
        public int SoNgayTro { get; set; }
        public string LoaiPhong { get; set; }
        public double GiaPhong { get; set; }

        public void Nhap()
        {
            Console.WriteLine("Nhập thông tin cá nhân:");
            ThongTinCaNhan.Nhap();

            Console.Write("Nhập số ngày trọ: ");
            SoNgayTro = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập loại phòng: ");
            LoaiPhong = Console.ReadLine();

            Console.Write("Nhập giá phòng mỗi ngày: ");
            GiaPhong = double.Parse(Console.ReadLine() ?? "0");
        }

        public void HienThi()
        {
            ThongTinCaNhan.HienThi();
            Console.WriteLine($"Loại phòng: {LoaiPhong}, Số ngày trọ: {SoNgayTro}, Giá phòng/ngày: {GiaPhong:C}");
        }

        public double TinhTien()
        {
            return SoNgayTro * GiaPhong;
        }

        public bool TimTheoTen(string ten)
        {
            return ThongTinCaNhan.HoTen.ToLower().Contains(ten.ToLower());
        }
    }

    // ===== Lớp KhachSan: Quản lý danh sách khách thuê phòng =====
    class KhachSan
    {
        private List<KhachThue> danhSachKhach = new List<KhachThue>();

        public void NhapDanhSach()
        {
            Console.Write("Nhập số lượng khách trọ: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin khách thứ {i + 1}:");
                KhachThue kt = new KhachThue();
                kt.Nhap();
                danhSachKhach.Add(kt);
            }
        }

        public void HienThiTatCa()
        {
            Console.WriteLine("\n==> Danh sách khách đang trọ:");
            foreach (var kt in danhSachKhach)
            {
                kt.HienThi();
                Console.WriteLine("----------------------");
            }
        }

        public void TimKiemTheoTen(string ten)
        {
            Console.WriteLine($"\n==> Kết quả tìm kiếm tên \"{ten}\":");
            bool timThay = false;
            foreach (var kt in danhSachKhach)
            {
                if (kt.TimTheoTen(ten))
                {
                    kt.HienThi();
                    Console.WriteLine($"-> Tổng tiền: {kt.TinhTien():C}");
                    timThay = true;
                }
            }

            if (!timThay)
                Console.WriteLine("Không tìm thấy khách nào có tên này.");
        }

        public void TinhTienKhach()
        {
            Console.Write("Nhập họ tên khách cần tính tiền: ");
            string ten = Console.ReadLine();
            bool timThay = false;

            foreach (var kt in danhSachKhach)
            {
                if (kt.TimTheoTen(ten))
                {
                    Console.WriteLine($"\nThông tin khách:");
                    kt.HienThi();
                    Console.WriteLine($"=> Tổng tiền phải trả: {kt.TinhTien():C}");
                    timThay = true;
                }
            }

            if (!timThay)
                Console.WriteLine("Không tìm thấy khách cần tính tiền.");
        }
    }
}
