using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._06_07_14_18
{
    internal class EX06_07_14_18
    {
        //EX06
        //Yêu cầu: Viết hàm `bool KiemTraNguyenTo(int n)` kiểm tra xem số nguyên n có phải số nguyên tố hay không.
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
        //EX07
        //Yêu cầu: Viết hàm `void InFibonacci(int n)` in ra n số đầu tiên của dãy Fibonacci.
        static void InFibonacci(int n1)
        {
            int a = 0, b = 1;
            for (int i = 0; i < n1; i++)
            {
                Console.Write($"{a} ");
                int c = a + b;
                a = b;
                b = c;
            }
        }
        //EX14
        //Yêu cầu: Viết hàm `int TongCacChuSo(int n)` để tính tổng từng chữ số tạo nên n. 
        static int TongCacChuSo(int n2)
        {
            int tong = 0;

            while (n2 != 0)
            {
                tong += n2 % 10;
                n2 /= 10;
            }

            return tong;
        }
        //EX18
        //Yêu cầu: Viết hàm `string DecimalToBinary(int n)` nhận vào số thập phân và trả về chuỗi nhị phân.
        static string DecimalToBinary(int n3)
        {
            if (n3 == 0)
                return "0";

            string Nhiphan = "";

            while (n3 > 0)
            {
                Nhiphan = (n3 % 2) + Nhiphan;
                n3 /= 2;
            }

            return Nhiphan;
        }
        public static void Main(string[] args)
        {
            //EX06
            Console.Write("Số n1: ");
            int n1 = int.Parse(Console.ReadLine());

            if (KiemTraNguyenTo(n1))
                Console.WriteLine($"{n1} là số nguyên tố");
            else
                Console.WriteLine($"{n1} không phải là số nguyên tố");

            //EX07
            Console.Write($"{n1} số đầu tiên của dãy Fibonacci: ");
            InFibonacci(n1);
            Console.WriteLine();

            //EX14
            Console.Write("Số n2: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Tổng các chữ số = " + TongCacChuSo(n2));

            //EX18
            Console.Write("Nhập số thập phân: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Số nhị phân: " + DecimalToBinary(n3));
        }

    }
}
