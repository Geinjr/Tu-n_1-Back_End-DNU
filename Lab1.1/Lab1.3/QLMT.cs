using System;

namespace bai_12
{
    public class MaTran
    {
        public int[,] M; // Mảng hai chiều để lưu trữ các phần tử của ma trận
        public int SoDong { get; set; } // Số dòng của ma trận
        public int SoCot { get; set; } // Số cột của ma trận

        // Hàm tạo không có đối số
        public MaTran()
        {
            SoDong = 0;
            SoCot = 0;
            M = new int[0, 0];
        }

        // Hàm tạo có đối số
        public MaTran(int n, int m)
        {
            SoDong = n;
            SoCot = m;
            M = new int[n, m];
        }

        // Phương thức nhập một ma trận
        public void Nhap()
        {
            Console.WriteLine("Nhập các phần tử của ma trận:");
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Console.Write($"M[{i + 1},{j + 1}] = ");
                    M[i, j] = int.Parse(Console.ReadLine() ?? "0");
                }
            }
        }

        // Phương thức hiển thị một ma trận
        public void HienThi()
        {
            Console.WriteLine("Ma trận là:");
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Phương thức cộng hai ma trận
        public static MaTran operator +(MaTran a, MaTran b)
        {
            if (a.SoDong != b.SoDong || a.SoCot != b.SoCot)
                throw new InvalidOperationException("Hai ma trận phải cùng cấp để cộng.");

            MaTran result = new MaTran(a.SoDong, a.SoCot);
            for (int i = 0; i < a.SoDong; i++)
            {
                for (int j = 0; j < a.SoCot; j++)
                {
                    result.M[i, j] = a.M[i, j] + b.M[i, j];
                }
            }
            return result;
        }

        // Phương thức trừ hai ma trận
        public static MaTran operator -(MaTran a, MaTran b)
        {
            if (a.SoDong != b.SoDong || a.SoCot != b.SoCot)
                throw new InvalidOperationException("Hai ma trận phải cùng cấp để trừ.");

            MaTran result = new MaTran(a.SoDong, a.SoCot);
            for (int i = 0; i < a.SoDong; i++)
            {
                for (int j = 0; j < a.SoCot; j++)
                {
                    result.M[i, j] = a.M[i, j] - b.M[i, j];
                }
            }
            return result;
        }

        // Phương thức nhân hai ma trận
        public static MaTran operator *(MaTran a, MaTran b)
        {
            if (a.SoCot != b.SoDong)
                throw new InvalidOperationException("Số cột của ma trận A phải bằng số dòng của ma trận B để nhân.");

            MaTran result = new MaTran(a.SoDong, b.SoCot);
            for (int i = 0; i < a.SoDong; i++)
            {
                for (int j = 0; j < b.SoCot; j++)
                {
                    result.M[i, j] = 0;
                    for (int k = 0; k < a.SoCot; k++)
                    {
                        result.M[i, j] += a.M[i, k] * b.M[k, j];
                    }
                }
            }
            return result;
        }

        // Phương thức chia hai ma trận
        public static MaTran operator /(MaTran a, MaTran b)
        {
            // Phép chia ma trận không hợp lệ trong toán học thông thường.
            // Thường là chia ma trận theo ngược (inverse), nhưng ta không thực hiện ở đây.
            throw new InvalidOperationException("Phép chia ma trận không được hỗ trợ.");
        }
    }
}
