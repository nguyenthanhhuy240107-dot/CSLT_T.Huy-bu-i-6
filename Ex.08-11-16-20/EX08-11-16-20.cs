using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._08_11_16_20
{
    internal class EX08_11_16_20
    {
        //EX08
        //Yêu cầu: Viết hàm `int DemNguyenAm(string s)` đếm số lượng các ký tự nguyên âm (a, e, i, o, u) trong chuỗi.
        static int DemNguyenAm(string s)
        {
            int dem = 0;

            foreach (char c in s)
            {
                char x = char.ToLower(c);

                if (x == 'a' || x == 'e' || x == 'i' ||
                    x == 'o' || x == 'u')
                {
                    dem++;
                }
            }

            return dem;
        }
        //EX11
        //Yêu cầu: Viết hàm `bool KiemTraDoiXung(string s)` kiểm tra chuỗi có đọc xuôi và ngược giống nhau không.
        static bool KiemTraDoiXung(string s)
        {
            int trai = 0;
            int phai = s.Length - 1;

            while (trai < phai)
            {
                if (s[trai] != s[phai])
                    return false;

                trai++;
                phai--;
            }

            return true;
        }        
        //EX16
        //Yêu cầu: Viết hàm `string XoaTrungLap(string s)` trả về chuỗi với các ký tự xuất hiện lần đầu tiên được giữ lại.
        static string XoaTrungLap(string s)
        {
            string ketQua = "";

            foreach (char c in s)
            {
                if (!ketQua.Contains(c))
                {
                    ketQua += c;
                }
            }

            return ketQua;
        }
        //EX20
        //Yêu cầu: Viết hàm `int DemSoTu(string sentence)` trả về số lượng từ có trong câu.
        static int DemSoTu(string sentence)
        {
            int dem = 0;
            bool trongTu = false;

            foreach (char c in sentence)
            {
                if (!char.IsWhiteSpace(c))
                {
                    if (!trongTu)
                    {
                        dem++;
                        trongTu = true;
                    }
                }
                else
                {
                    trongTu = false;
                }
            }

            return dem;
        }
        public static void Main(string[] args)
        {
            //EX08
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine();

            Console.WriteLine($"Số lượng nguyên âm: {DemNguyenAm(s)}");
            //EX11
            Console.WriteLine($"Chuỗi đối xứng: {KiemTraDoiXung(s)}");
            //EX16
            Console.WriteLine($"Chuỗi sau khi xóa trùng lặp: {XoaTrungLap(s)}");
            //EX20
            Console.WriteLine($"Số lượng từ: {DemSoTu(s)}");
        }
    }
}
