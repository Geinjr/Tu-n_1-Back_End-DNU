using System;

namespace bai_11

{
    public class SoPhuc
    {
        public double PhanThuc { get; set; }
        public double PhanAo { get; set; }

        // Hàm tạo không có đối số
        public SoPhuc()
        {
            PhanThuc = 0;
            PhanAo = 0;
        }

        // Hàm tạo có đối số
        public SoPhuc(double a, double b)
        {
            PhanThuc = a;
            PhanAo = b;
        }

        // Phương thức nhập một số phức
        public void Nhap()
        {
            Console.Write("Nhập phần thực: ");
            PhanThuc = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập phần ảo: ");
            PhanAo = double.Parse(Console.ReadLine() ?? "0");
        }

        // Phương thức hiển thị một số phức
        public void HienThi()
        {
            if (PhanAo >= 0)
                Console.WriteLine($"{PhanThuc} + {PhanAo}i");
            else
                Console.WriteLine($"{PhanThuc} - {-PhanAo}i");
        }

        // Phương thức cộng hai số phức
        public static SoPhuc operator +(SoPhuc a, SoPhuc b)
        {
            return new SoPhuc(a.PhanThuc + b.PhanThuc, a.PhanAo + b.PhanAo);
        }

        // Phương thức trừ hai số phức
        public static SoPhuc operator -(SoPhuc a, SoPhuc b)
        {
            return new SoPhuc(a.PhanThuc - b.PhanThuc, a.PhanAo - b.PhanAo);
        }

        // Phương thức nhân hai số phức
        public static SoPhuc operator *(SoPhuc a, SoPhuc b)
        {
            double phanThuc = a.PhanThuc * b.PhanThuc - a.PhanAo * b.PhanAo;
            double phanAo = a.PhanThuc * b.PhanAo + a.PhanAo * b.PhanThuc;
            return new SoPhuc(phanThuc, phanAo);
        }

        // Phương thức chia hai số phức
        public static SoPhuc operator /(SoPhuc a, SoPhuc b)
        {
            double mau = b.PhanThuc * b.PhanThuc + b.PhanAo * b.PhanAo;
            double phanThuc = (a.PhanThuc * b.PhanThuc + a.PhanAo * b.PhanAo) / mau;
            double phanAo = (a.PhanAo * b.PhanThuc - a.PhanThuc * b.PhanAo) / mau;
            return new SoPhuc(phanThuc, phanAo);
        }
    }
}
