using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._10_13_15
{
    internal class Ex10_13_15
    {
        //EX10
        //Yêu cầu: Viết hàm `double TinhTrungBinh(int[] arr)` tính giá trị trung bình của mảng số nguyên.
        static double TinhTrungBinh(int[] arr)
        {
            if (arr.Length == 0) return 0;
            double tong = 0;
            foreach (int x in arr)
            {
                tong += x;
            }
            return tong / arr.Length;
        }
        //EX13
        //Yêu cầu: Viết hàm `int TimMin(int[] arr)` trả về phần tử nhỏ nhất trong mảng.
        static int TimMin(int[] arr)
        {
            if (arr.Length == 0) throw new ArgumentException("Mảng rỗng!");
            int min = arr[0];
            foreach (int x in arr)
            {
                if (x < min) min = x;
            }
            return min;
        }
        //EX15
        //Yêu cầu: Viết hàm `void SapXepMang(int[] arr)` sắp xếp và in ra mảng tăng dần.
        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr); // dùng hàm có sẵn
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            Console.Write("Số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            //EX10
            Console.WriteLine($"Trung bình = {TinhTrungBinh(arr)}");
            //EX13
            Console.WriteLine($"Min = {TimMin(arr)}");
            //EX15
            SapXepMang(arr);
        }
    }
}
