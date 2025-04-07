using System;
using System.Text;
using System.Linq;

class Program
{
    static int SumEvenNumbers(int[] arr)
    {
        return arr.Where(x => x % 2 == 0).Sum();
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    static void CountPositiveNegative(int[] arr, out int positiveCount, out int negativeCount)
    {
        positiveCount = arr.Count(x => x > 0);
        negativeCount = arr.Count(x => x < 0);
    }

    static int SecondLargest(int[] arr)
    {
        var distinctSorted = arr.Distinct().OrderByDescending(x => x).ToList();
        return distinctSorted.Count > 1 ? distinctSorted[1] : int.MinValue;
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void SortArray(double[] arr)
    {
        Array.Sort(arr);
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Nhập mảng từ bàn phím
        Console.Write("Nhập số phần tử của mảng: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Bài 1: Tính tổng số chẵn
        Console.WriteLine($"Tổng các số chẵn: {SumEvenNumbers(arr)}");

        // Bài 2: Tìm số nguyên tố
        Console.WriteLine("Các số nguyên tố trong mảng:");
        for (int i = 0; i < n; i++)
        {
            if (IsPrime(arr[i]))
            {
                Console.WriteLine($"Phần tử {arr[i]} ở vị trí {i}");
            }
        }

        // Bài 3: Đếm số âm và số dương
        CountPositiveNegative(arr, out int positiveCount, out int negativeCount);
        Console.WriteLine($"Số dương: {positiveCount}, Số âm: {negativeCount}");

        // Bài 4: Tìm số lớn thứ hai
        int secondLargest = SecondLargest(arr);
        Console.WriteLine(secondLargest == int.MinValue ? "Không có số lớn thứ hai" : $"Số lớn thứ hai: {secondLargest}");

        // Bài 5: Hoán vị hai số
        Console.Write("Nhập số a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập số b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Swap(ref a, ref b);
        Console.WriteLine($"Sau khi hoán vị: a = {a}, b = {b}");

        // Bài 6: Sắp xếp mảng số thực tăng dần
        Console.Write("Nhập số phần tử của mảng số thực: ");
        int m = Convert.ToInt32(Console.ReadLine());
        double[] realArr = new double[m];
        for (int i = 0; i < m; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            realArr[i] = Convert.ToDouble(Console.ReadLine());
        }
        SortArray(realArr);
        Console.WriteLine("Mảng sau khi sắp xếp: " + string.Join(", ", realArr));
    }
}

