using System;
using System.Collections.Generic;

namespace bai_2
{
    // Lớp cơ sở TaiLieu
    class TaiLieu
    {
        public string MaTaiLieu { get; set; }
        public string TenNhaXuatBan { get; set; }
        public int SoBanPhatHanh { get; set; }

        public virtual void NhapThongTin()
        {
            Console.Write("Nhập mã tài liệu: ");
            MaTaiLieu = Console.ReadLine();
            Console.Write("Nhập tên nhà xuất bản: ");
            TenNhaXuatBan = Console.ReadLine();
            Console.Write("Nhập số bản phát hành: ");
            SoBanPhatHanh = int.Parse(Console.ReadLine());
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Mã tài liệu: {MaTaiLieu}, Nhà xuất bản: {TenNhaXuatBan}, Số bản phát hành: {SoBanPhatHanh}");
        }
    }

    // Lớp Sach kế thừa TaiLieu
    class Sach : TaiLieu
    {
        public string TenTacGia { get; set; }
        public int SoTrang { get; set; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhập tên tác giả: ");
            TenTacGia = Console.ReadLine();
            Console.Write("Nhập số trang: ");
            SoTrang = int.Parse(Console.ReadLine());
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Tác giả: {TenTacGia}, Số trang: {SoTrang}");
        }
    }

    // Lớp TapChi kế thừa TaiLieu
    class TapChi : TaiLieu
    {
        public int SoPhatHanh { get; set; }
        public string ThangPhatHanh { get; set; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhập số phát hành: ");
            SoPhatHanh = int.Parse(Console.ReadLine());
            Console.Write("Nhập tháng phát hành: ");
            ThangPhatHanh = Console.ReadLine();
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Số phát hành: {SoPhatHanh}, Tháng phát hành: {ThangPhatHanh}");
        }
    }

    // Lớp Bao kế thừa TaiLieu
    class Bao : TaiLieu
    {
        public string NgayPhatHanh { get; set; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhập ngày phát hành: ");
            NgayPhatHanh = Console.ReadLine();
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Ngày phát hành: {NgayPhatHanh}");
        }
    }

    // Lớp QuanLyTailieu
    class QuanLyTailieu
    {
        private List<TaiLieu> danhSachTaiLieu = new List<TaiLieu>();

        public void ThemTaiLieu()
        {
            Console.WriteLine("Chọn loại tài liệu cần thêm:");
            Console.WriteLine("1. Sách");
            Console.WriteLine("2. Tạp chí");
            Console.WriteLine("3. Báo");
            Console.Write("Nhập lựa chọn: ");
            int chon = int.Parse(Console.ReadLine());

            TaiLieu tl;

            switch (chon)
            {
                case 1:
                    tl = new Sach();
                    break;
                case 2:
                    tl = new TapChi();
                    break;
                case 3:
                    tl = new Bao();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    return;
            }

            tl.NhapThongTin();
            danhSachTaiLieu.Add(tl);
        }

        public void HienThiDanhSachTaiLieu()
        {
            Console.WriteLine("Danh sách tài liệu:");
            foreach (var tl in danhSachTaiLieu)
            {
                tl.HienThiThongTin();
            }
        }

        public void TimKiemTheoLoai()
        {
            Console.WriteLine("Tìm kiếm tài liệu theo loại:");
            Console.WriteLine("1. Sách");
            Console.WriteLine("2. Tạp chí");
            Console.WriteLine("3. Báo");
            Console.Write("Nhập lựa chọn: ");
            int chon = int.Parse(Console.ReadLine());

            foreach (var tl in danhSachTaiLieu)
            {
                if ((chon == 1 && tl is Sach) || (chon == 2 && tl is TapChi) || (chon == 3 && tl is Bao))
                {
                    tl.HienThiThongTin();
                }
            }
        }
    }

    // Chương trình chính
    class Program
    {
        static void Main()
        {
            QuanLyTailieu qltl = new QuanLyTailieu();
            while (true)
            {
                Console.WriteLine("1. Thêm tài liệu");
                Console.WriteLine("2. Hiển thị danh sách tài liệu");
                Console.WriteLine("3. Tìm kiếm tài liệu theo loại");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                int chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        qltl.ThemTaiLieu();
                        break;
                    case 2:
                        qltl.HienThiDanhSachTaiLieu();
                        break;
                    case 3:
                        qltl.TimKiemTheoLoai();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}
