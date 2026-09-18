using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._09_12_17_19
{
    internal class EX09_12_17_19
    {
        //EX09
        //Yêu cầu: Viết hàm `double TinhLuyThua(double x, int y)` tính x^y (không dùng Math.Pow).
        static double TinhLuyThua(double x, int y)
        {
            double ketQua = 1;
            bool am = y < 0;
            int mu = Math.Abs(y);

            for (int i = 0; i < mu; i++)
            {
                ketQua *= x;
            }

            if (am) return 1.0 / ketQua;
            return ketQua;
        }
        //EX12
        //Yêu cầu: Viết hàm `double CelsiusToFahrenheit(double c)` chuyển đổi từ độ C sang độ F.
        static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
        //EX17
        //Yêu cầu: Viết hàm `int UCLN(int a, int b)` sử dụng thuật toán Euclid để tìm UCLN của 2 số.
        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        //EX19
        //Yêu cầu: Viết hàm `bool KiemTraNamNhuan(int year)` kiểm tra xem một năm có phải năm nhuận không.
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }
        public static void Main(string[] args)
        {
            //EX09
            Console.Write("Nhập x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhập y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Kết quả x^y = {TinhLuyThua(x, y)}");
            //EX12
            Console.Write("Nhập nhiệt độ C: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Độ F = {CelsiusToFahrenheit(c)}");
            //EX17
            Console.Write("Nhập số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
            //EX19
            Console.Write("Nhập năm: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"Năm {year} {(KiemTraNamNhuan(year) ? "là năm nhuận" : "không phải năm nhuận")}");
        }
    }
}
