using System;
using System.Collections.Generic;

namespace bai_13
{
    // Lớp PTGT - Phương tiện giao thông
    public class PTGT
    {
        public string HangSanXuat { get; set; }
        public int NamSanXuat { get; set; }
        public double GiaBan { get; set; }
        public string Mau { get; set; }

        // Hàm khởi tạo không tham số
        public PTGT() { }

        // Hàm khởi tạo có tham số
        public PTGT(string hangSanXuat, int namSanXuat, double giaBan, string mau)
        {
            HangSanXuat = hangSanXuat;
            NamSanXuat = namSanXuat;
            GiaBan = giaBan;
            Mau = mau;
        }

        // Phương thức hiển thị thông tin phương tiện giao thông
        public virtual void HienThi()
        {
            Console.WriteLine($"Hãng sản xuất: {HangSanXuat}");
            Console.WriteLine($"Năm sản xuất: {NamSanXuat}");
            Console.WriteLine($"Giá bán: {GiaBan} VND");
            Console.WriteLine($"Màu sắc: {Mau}");
        }
    }

    // Lớp con - Ô tô
    public class OTo : PTGT
    {
        public int SoChoNgoi { get; set; }
        public string KieuDongCo { get; set; }

        // Hàm khởi tạo không tham số
        public OTo() { }

        // Hàm khởi tạo có tham số
        public OTo(string hangSanXuat, int namSanXuat, double giaBan, string mau, int soChoNgoi, string kieuDongCo)
            : base(hangSanXuat, namSanXuat, giaBan, mau)
        {
            SoChoNgoi = soChoNgoi;
            KieuDongCo = kieuDongCo;
        }

        // Phương thức hiển thị thông tin ô tô
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Số chỗ ngồi: {SoChoNgoi}");
            Console.WriteLine($"Kiểu động cơ: {KieuDongCo}");
        }
    }

    // Lớp con - Xe máy
    public class XeMay : PTGT
    {
        public double CongSuat { get; set; }

        // Hàm khởi tạo không tham số
        public XeMay() { }

        // Hàm khởi tạo có tham số
        public XeMay(string hangSanXuat, int namSanXuat, double giaBan, string mau, double congSuat)
            : base(hangSanXuat, namSanXuat, giaBan, mau)
        {
            CongSuat = congSuat;
        }

        // Phương thức hiển thị thông tin xe máy
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Công suất: {CongSuat} mã lực");
        }
    }

    // Lớp con - Xe tải
    public class XeTai : PTGT
    {
        public double TrongTai { get; set; }

        // Hàm khởi tạo không tham số
        public XeTai() { }

        // Hàm khởi tạo có tham số
        public XeTai(string hangSanXuat, int namSanXuat, double giaBan, string mau, double trongTai)
            : base(hangSanXuat, namSanXuat, giaBan, mau)
        {
            TrongTai = trongTai;
        }

        // Phương thức hiển thị thông tin xe tải
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Trọng tải: {TrongTai} tấn");
        }
    }

    // Lớp quản lý phương tiện giao thông
    public class QLPTGT
    {
        private List<PTGT> danhSachPTGT = new List<PTGT>();

        // Phương thức nhập phương tiện giao thông
        public void NhapPhuongTien()
        {
            Console.WriteLine("Nhập thông tin phương tiện giao thông:");
            Console.Write("Loại phương tiện (1: Ô tô, 2: Xe máy, 3: Xe tải): ");
            int loaiPT = int.Parse(Console.ReadLine());

            Console.Write("Hãng sản xuất: ");
            string hangSanXuat = Console.ReadLine();
            Console.Write("Năm sản xuất: ");
            int namSanXuat = int.Parse(Console.ReadLine());
            Console.Write("Giá bán: ");
            double giaBan = double.Parse(Console.ReadLine());
            Console.Write("Màu sắc: ");
            string mau = Console.ReadLine();

            PTGT pt = null;

            if (loaiPT == 1)
            {
                Console.Write("Số chỗ ngồi: ");
                int soChoNgoi = int.Parse(Console.ReadLine());
                Console.Write("Kiểu động cơ: ");
                string kieuDongCo = Console.ReadLine();
                pt = new OTo(hangSanXuat, namSanXuat, giaBan, mau, soChoNgoi, kieuDongCo);
            }
            else if (loaiPT == 2)
            {
                Console.Write("Công suất: ");
                double congSuat = double.Parse(Console.ReadLine());
                pt = new XeMay(hangSanXuat, namSanXuat, giaBan, mau, congSuat);
            }
            else if (loaiPT == 3)
            {
                Console.Write("Trọng tải: ");
                double trongTai = double.Parse(Console.ReadLine());
                pt = new XeTai(hangSanXuat, namSanXuat, giaBan, mau, trongTai);
            }

            if (pt != null)
                danhSachPTGT.Add(pt);

            Console.WriteLine("Đã thêm phương tiện giao thông thành công.");
        }

        // Phương thức tìm phương tiện theo màu hoặc năm sản xuất
        public void TimPhuongTien()
        {
            Console.WriteLine("Tìm phương tiện theo (1: Màu sắc, 2: Năm sản xuất): ");
            int chon = int.Parse(Console.ReadLine());

            if (chon == 1)
            {
                Console.Write("Nhập màu sắc cần tìm: ");
                string mau = Console.ReadLine();

                foreach (var pt in danhSachPTGT)
                {
                    if (pt.Mau.Equals(mau, StringComparison.OrdinalIgnoreCase))
                    {
                        pt.HienThi();
                        Console.WriteLine();
                    }
                }
            }
            else if (chon == 2)
            {
                Console.Write("Nhập năm sản xuất cần tìm: ");
                int nam = int.Parse(Console.ReadLine());

                foreach (var pt in danhSachPTGT)
                {
                    if (pt.NamSanXuat == nam)
                    {
                        pt.HienThi();
                        Console.WriteLine();
                    }
                }
            }
        }

        // Phương thức kết thúc chương trình
        public void KetThuc()
        {
            Console.WriteLine("Kết thúc chương trình.");
        }
    }

    // Chương trình chính
    class Program
    {
        static void Main(string[] args)
        {
            QLPTGT qlptgt = new QLPTGT();
            bool run = true;

            while (run)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Nhập đăng ký phương tiện");
                Console.WriteLine("2. Tìm phương tiện theo màu hoặc năm sản xuất");
                Console.WriteLine("3. Kết thúc chương trình");
                Console.Write("Chọn chức năng: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        qlptgt.NhapPhuongTien();
                        break;
                    case "2":
                        qlptgt.TimPhuongTien();
                        break;
                    case "3":
                        qlptgt.KetThuc();
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            }
        }
    }
}
