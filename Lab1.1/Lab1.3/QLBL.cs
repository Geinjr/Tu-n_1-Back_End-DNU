using System;
using System.Collections.Generic;

namespace bai_9
{
    // ===== Lớp KhachHang: Quản lý thông tin hộ sử dụng điện =====
    public class KhachHang
    {
        public string HoTen { get; set; }
        public string SoNha { get; set; }
        public string MaSoCongTo { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập họ tên chủ hộ: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập số nhà: ");
            SoNha = Console.ReadLine();

            Console.Write("Nhập mã số công tơ: ");
            MaSoCongTo = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.WriteLine($"Họ tên chủ hộ: {HoTen}, Số nhà: {SoNha}, Mã số công tơ: {MaSoCongTo}");
        }
    }

    // ===== Lớp BienLai: Quản lý biên lai thu tiền điện =====
    public class BienLai
    {
        public KhachHang KhachHang { get; set; }
        public double ChiSoCu { get; set; }
        public double ChiSoMoi { get; set; }
        public double SoTienPhaiTra { get; set; }

        public void Nhap()
        {
            KhachHang = new KhachHang();
            Console.WriteLine("=== Nhập thông tin hộ sử dụng điện ===");
            KhachHang.Nhap();

            Console.Write("Nhập chỉ số cũ: ");
            ChiSoCu = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập chỉ số mới: ");
            ChiSoMoi = double.Parse(Console.ReadLine() ?? "0");
        }

        public void TinhTien()
        {
            double soDienSuDung = ChiSoMoi - ChiSoCu;

            if (soDienSuDung <= 50)
                SoTienPhaiTra = soDienSuDung * 1250;
            else if (soDienSuDung <= 100)
                SoTienPhaiTra = soDienSuDung * 1500;
            else
                SoTienPhaiTra = soDienSuDung * 2000;
        }

        public void HienThi()
        {
            KhachHang.HienThi();
            Console.WriteLine($"Chỉ số cũ: {ChiSoCu}, Chỉ số mới: {ChiSoMoi}, Số điện sử dụng: {ChiSoMoi - ChiSoCu}, Số tiền phải trả: {SoTienPhaiTra} VND");
        }
    }

    // ===== Quản lý danh sách biên lai =====
    public class QuanLyBienLai
    {
        public List<BienLai> DanhSachBienLai = new List<BienLai>();

        public void NhapDanhSach()
        {
            Console.Write("Nhập số hộ sử dụng điện: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n-- Nhập thông tin biên lai cho hộ {i + 1} --");
                BienLai bienLai = new BienLai();
                bienLai.Nhap();
                bienLai.TinhTien();
                DanhSachBienLai.Add(bienLai);
            }
        }

        public void HienThiTatCa()
        {
            Console.WriteLine("\n== Danh sách biên lai đã nhập ==");
            foreach (var bienLai in DanhSachBienLai)
            {
                bienLai.HienThi();
            }
        }
    }
}
