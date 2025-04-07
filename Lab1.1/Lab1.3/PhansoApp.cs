using System;

namespace bai_14
{
    public class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        // Hàm tạo không tham số
        public PhanSo() { }

        // Hàm tạo có tham số
        public PhanSo(int tu, int mau)
        {
            TuSo = tu;
            MauSo = mau;
        }

        // Phương thức nhập phân số
        public void NhapPhanSo()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());

            // Kiểm tra mẫu số có phải bằng 0 hay không
            if (MauSo == 0)
            {
                Console.WriteLine("Mẫu số không được bằng 0. Vui lòng nhập lại!");
                MauSo = int.Parse(Console.ReadLine());
            }
        }

        // Phương thức hiển thị phân số
        public void HienThiPhanSo()
        {
            Console.WriteLine($"{TuSo}/{MauSo}");
        }

        // Phương thức rút gọn phân số
        public void RutGon()
        {
            int gcd = TimUCLN(TuSo, MauSo);  // Tìm ước chung lớn nhất
            TuSo /= gcd;
            MauSo /= gcd;
        }

        // Phương thức tìm ước chung lớn nhất
        private int TimUCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Phương thức cộng hai phân số
        public PhanSo Cong(PhanSo ps)
        {
            int tu = this.TuSo * ps.MauSo + ps.TuSo * this.MauSo;
            int mau = this.MauSo * ps.MauSo;
            PhanSo result = new PhanSo(tu, mau);
            result.RutGon();
            return result;
        }

        // Phương thức trừ hai phân số
        public PhanSo Tru(PhanSo ps)
        {
            int tu = this.TuSo * ps.MauSo - ps.TuSo * this.MauSo;
            int mau = this.MauSo * ps.MauSo;
            PhanSo result = new PhanSo(tu, mau);
            result.RutGon();
            return result;
        }

        // Phương thức chia hai phân số
        public PhanSo Chia(PhanSo ps)
        {
            int tu = this.TuSo * ps.MauSo;
            int mau = this.MauSo * ps.TuSo;

            // Kiểm tra chia cho 0
            if (ps.TuSo == 0)
            {
                Console.WriteLine("Không thể chia cho phân số có tử số bằng 0!");
                return null;
            }

            PhanSo result = new PhanSo(tu, mau);
            result.RutGon();
            return result;
        }
    }
}
