

//Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
//Công thức: F = (C * 9 / 5) + 32

using System.Text;

class Program
{
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; // Đảm bảo hỗ trợ tiếng Việt

        try
        {
            Console.Write("Nhập nhiệt độ (°C): ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(celsius);

            Console.WriteLine($"{celsius}°C = {fahrenheit:F2}°F");
        }
        catch (FormatException)
        {
            Console.WriteLine("Vui lòng nhập một số hợp lệ.");
        }
    }
}


using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Bài 4: Kiểm tra số chẵn
        Console.Write("Nhập một số nguyên: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number % 2 == 0 ? "Số chẵn" : "Số lẻ");

        // Bài 5: Tính tổng và tích
        Console.Write("Nhập số thứ nhất: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Tổng: {num1 + num2}, Tích: {num1 * num2}");

        // Bài 6: Kiểm tra số âm, dương, hoặc 0
        Console.Write("Nhập một số: ");
        int checkNum = Convert.ToInt32(Console.ReadLine());
        if (checkNum > 0) Console.WriteLine("Số dương");
        else if (checkNum < 0) Console.WriteLine("Số âm");
        else Console.WriteLine("Số 0");

        // Bài 7: Kiểm tra năm nhuận
        Console.Write("Nhập một năm: ");
        int year = Convert.ToInt32(Console.ReadLine());
        bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        Console.WriteLine(isLeap ? "Năm nhuận" : "Không phải năm nhuận");

        // Bài 8: In bảng cửu chương
        Console.WriteLine("Bảng cửu chương từ 1 đến 10:");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i} x {j} = {i * j}\t");
            }
            Console.WriteLine();
        }

        // Bài 9: Tính giai thừa
        Console.Write("Nhập số nguyên dương n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        long factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"Giai thừa của {n} là {factorial}");

        // Bài 10: Kiểm tra số nguyên tố
        Console.Write("Nhập một số nguyên: ");
        int primeNum = Convert.ToInt32(Console.ReadLine());
        bool isPrime = primeNum > 1;
        for (int i = 2; i <= Math.Sqrt(primeNum); i++)
        {
            if (primeNum % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine(isPrime ? "Là số nguyên tố" : "Không phải số nguyên tố");
    }
}

