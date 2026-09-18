using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._01_05
{
    internal class Program
    {   //EX01
        //Yêu cầu: Viết hàm `int TinhTong(int a, int b)` nhận vào hai số nguyên và trả về tổng của chúng. 
        //Hướng dẫn: Bên trong thân hàm, bạn sử dụng từ khóa `return a + b;`.Trong hàm `Main`, gọi hàm này, truyền vào 2số cụ thể và in kết quả ra màn hình.
        static int TinhTong(int a, int b)
        {
            return a + b;
        }
        //EX02
        //Yêu cầu: Viết hàm `bool KiemTraChan(int n)` trả về `true` nếu `n` là số chẵn, `false` nếu là số lẻ. 
        //Hướng dẫn: Sử dụng toán tử chia lấy dư `%`. Nếu biểu thức `n % 2 == 0` đúng thì n là số chẵn.Bạn có thể return thẳng biểu thức này.
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }
        //EX03
        //Yêu cầu: Viết hàm `int TimMax(int a, int b, int c)` trả về giá trị lớn nhất trong ba số được truyền vào. 
        //Hướng dẫn: Bạn có thể sử dụng cấu trúc điều kiện `if-else` lồng nhau.Cách ngắn gọn hơn là tận dụng hàm có sẵn`Math.Max(Math.Max(a, b), c)`.
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        //EX04
        //Yêu cầu: Viết hàm `long TinhGiaiThua(int n)` tính và trả về giai thừa của số nguyên dương n (n!). 
        //Hướng dẫn: Sử dụng một biến lưu kết quả(khởi tạo bằng 1). Dùng vòng lặp `for` chạy từ 1 đến `n` để nhân dồn vào biến kết quả.Chú ý: dùng kiểu `long` để tránh tràn số lượng giới hạn của `int`.
        static long TinhGiaiThua(int n)
        {
            long Ketqua = 1;

            for (int i = 1; i <= n; i++)
            {
                Ketqua *= i;
            }

            return Ketqua;
        }
        //EX05
        //Yêu cầu: Viết hàm `string DaoNguocChuoi(string input)` nhận vào một chuỗi và trả về chuỗi bị đảo ngược. 
        //Hướng dẫn: Chuyển chuỗi thành mảng ký tự `char[]` bằng phương thức `.ToCharArray()`. Sau đó dùng hàm `Array.Reverse()` để đảo mảng, cuối cùng tạo lại chuỗi mới bằng `new string (char_array)`.
        static string DaoNguocChuoi(string input)
        {
            char[] char_array = input.ToCharArray();
            Array.Reverse(char_array);

            return new string(char_array);
        }
        public static void Main(string[] args)
        {
            Console.Write("Số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Số b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Số n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Số c: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Chuỗi: ");
            string input = Console.ReadLine();
            //EX01
            Console.WriteLine($"Tổng= {TinhTong(a, b)}");

            //EX02
            if (KiemTraChan(n))
            {
                Console.WriteLine($"{n} là số chẵn");
            }
            else
            {
                Console.WriteLine($"{n} là số lẻ");
            }
            //EX03
            Console.WriteLine($"Giá trị lớn nhất là {TimMax(a, b, c)}");
            //EX04
            Console.WriteLine($"{n}! = {TinhGiaiThua(n)}");
            //EX05
            Console.WriteLine($"Chuỗi đảo ngược: {DaoNguocChuoi(input)}");
        }
    }
}

