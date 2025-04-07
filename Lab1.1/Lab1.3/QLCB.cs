

using System;
using System.Collections.Generic;

namespace bai_1
{
    class CanBo
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public virtual void NhapThongTin()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập giới tính: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Giới tính: {GioiTinh}, Địa chỉ: {DiaChi}");
        }
    }

    class CongNhan : CanBo
    {
        public int Bac { get; set; }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhập bậc công nhân: ");
            Bac = int.Parse(Console.ReadLine());
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Bậc: {Bac}");
        }
    }

    class KySu : CanBo
    {
        public string NganhDaoTao { get; set; }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhập ngành đào tạo: ");
            NganhDaoTao = Console.ReadLine();
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Ngành đào tạo: {NganhDaoTao}");
        }
    }

    class NhanVien : CanBo
    {
        public string CongViec { get; set; }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhập công việc: ");
            CongViec = Console.ReadLine();
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Công việc: {CongViec}");
        }
    }

    class QLCB
    {
        private List<CanBo> danhSachCanBo = new List<CanBo>();

        public void ThemCanBo()
        {
            Console.Write("Chọn loại cán bộ (1-Công nhân, 2-Kỹ sư, 3-Nhân viên): ");
            int chon = int.Parse(Console.ReadLine());
            CanBo cb;
            switch (chon)
            {
                case 1: cb = new CongNhan(); break;
                case 2: cb = new KySu(); break;
                case 3: cb = new NhanVien(); break;
                default: Console.WriteLine("Lựa chọn không hợp lệ!"); return;
            }
            cb.NhapThongTin();
            danhSachCanBo.Add(cb);
        }

        public void TimKiemTheoHoTen()
        {
            Console.Write("Nhập họ tên cần tìm: ");
            string hoTen = Console.ReadLine();
            foreach (var cb in danhSachCanBo)
            {
                if (cb.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase))
                {
                    cb.HienThiThongTin();
                }
            }
        }

        public void HienThiDanhSach()
        {
            Console.WriteLine("Danh sách cán bộ:");
            foreach (var cb in danhSachCanBo)
            {
                cb.HienThiThongTin();
            }
        }
    }
}


