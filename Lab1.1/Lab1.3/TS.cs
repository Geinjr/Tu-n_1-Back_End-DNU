using System;
using System.Collections.Generic;

namespace bai_3
{
    // Lớp cơ sở ThiSinh
    class ThiSinh
    {
        public string SoBaoDanh { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string UuTien { get; set; }
        public virtual void NhapThongTin()
        {
            Console.Write("Nhập số báo danh: ");
            SoBaoDanh = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhập ưu tiên: ");
            UuTien = Console.ReadLine();
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Số báo danh: {SoBaoDanh}, Họ tên: {HoTen}, Địa chỉ: {DiaChi}, Ưu tiên: {UuTien}");
        }

        public virtual double TinhDiem()
        {
            return 0; // Mỗi khối thi sẽ tính điểm khác nhau, nên phương thức này sẽ được ghi đè.
        }
    }

    // Lớp ThiSinhKhoiA kế thừa ThiSinh
    class ThiSinhKhoiA : ThiSinh
    {
        public double Toan { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhập điểm Toán: ");
            Toan = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Lý: ");
            Ly = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Hóa: ");
            Hoa = double.Parse(Console.ReadLine());
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Điểm Toán: {Toan}, Điểm Lý: {Ly}, Điểm Hóa: {Hoa}");
        }
        public override double TinhDiem()
        {
            // Điểm chuẩn khối A là 15
            return Toan + Ly + Hoa;
        }
    }

    // Lớp ThiSinhKhoiB kế thừa ThiSinh
    class ThiSinhKhoiB : ThiSinh
    {
        public double Toan { get; set; }
        public double Hoa { get; set; }
        public double Sinh { get; set; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhập điểm Toán: ");
            Toan = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Hóa: ");
            Hoa = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Sinh: ");
            Sinh = double.Parse(Console.ReadLine());
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Điểm Toán: {Toan}, Điểm Hóa: {Hoa}, Điểm Sinh: {Sinh}");
        }

        public override double TinhDiem()
        {
            // Điểm chuẩn khối B là 16
            return Toan + Hoa + Sinh;
        }
    }

    // Lớp ThiSinhKhoiC kế thừa ThiSinh
    class ThiSinhKhoiC : ThiSinh
    {
        public double Van { get; set; }
        public double Su { get; set; }
        public double Dia { get; set; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhập điểm Văn: ");
            Van = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Sử: ");
            Su = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Địa: ");
            Dia = double.Parse(Console.ReadLine());
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Điểm Văn: {Van}, Điểm Sử: {Su}, Điểm Địa: {Dia}");
        }

        public override double TinhDiem()
        {
            // Điểm chuẩn khối C là 13.5
            return Van + Su + Dia;
        }
    }

    // Lớp QuanLyThiSinh quản lý các thí sinh
    class QuanLyTuyenSinh
    {
        private List<ThiSinh> danhSachThiSinh = new List<ThiSinh>();

        public void NhapThiSinh()
        {
            Console.WriteLine("Chọn loại thí sinh (1-Khối A, 2-Khối B, 3-Khối C): ");
            int chon = int.Parse(Console.ReadLine());
            ThiSinh ts;

            switch (chon)
            {
                case 1:
                    ts = new ThiSinhKhoiA();
                    break;
                case 2:
                    ts = new ThiSinhKhoiB();
                    break;
                case 3:
                    ts = new ThiSinhKhoiC();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    return;
            }

            ts.NhapThongTin();
            danhSachThiSinh.Add(ts);
        }

        public void HienThiDanhSachThiSinh()
        {
            Console.WriteLine("Danh sách thí sinh đã trúng tuyển:");
            foreach (var ts in danhSachThiSinh)
            {
                double diem = ts.TinhDiem();
                Console.WriteLine($"SBD: {ts.SoBaoDanh}, Họ tên: {ts.HoTen}, Diểm: {diem}");

                if (ts is ThiSinhKhoiA && diem >= 15)
                    ts.HienThiThongTin();
                else if (ts is ThiSinhKhoiB && diem >= 16)
                    ts.HienThiThongTin();
                else if (ts is ThiSinhKhoiC && diem >= 13.5)
                    ts.HienThiThongTin();
            }
        }

        public void TimKiemTheoSoBaoDanh()
        {
            Console.Write("Nhập số báo danh cần tìm: ");
            string sbd = Console.ReadLine();
            bool found = false;

            foreach (var ts in danhSachThiSinh)
            {
                if (ts.SoBaoDanh.Equals(sbd, StringComparison.OrdinalIgnoreCase))
                {
                    ts.HienThiThongTin();
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("Không tìm thấy thí sinh với số báo danh này!");
        }
    };

