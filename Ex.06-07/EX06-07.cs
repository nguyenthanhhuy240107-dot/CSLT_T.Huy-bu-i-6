using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._06_07
{
    internal class Program
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
        static void InFibonacci(int n)
        {
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a} ");
                int c = a + b;
                a = b;
                b = c;
            }
        }
        public static void Main(string[] args)
        {
            //EX06
            Console.Write("Số n: ");
            int n = int.Parse(Console.ReadLine());

            if (KiemTraNguyenTo(n))
                Console.WriteLine($"{n} là số nguyên tố");
            else
                Console.WriteLine($"{n} không phải là số nguyên tố");

            //EX07
            InFibonacci(n);
        }
    }
}
