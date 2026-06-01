using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Channels;

namespace Ha_Thanh_Truc_.BAI_5
{
    internal class _1
    { static void Main67(string[] args)
        { //ex01();
            //ex02();
            //ex03();
            //ex04();
            //ex05();
            //ex06();
            //ex07();
            //ex08();
            //ex09();
            //ex10();
            //ex11();
            //ex12();
            //ex13();
            //ex14();
            //ex15();
            ex16();
            //ex17();
            //ex18();
            //ex19();
            //ex20();
        }
        public static int Tong(int a, int b)
        {
            return a + b;
        }

        public static bool KiemTraChanLe(int a)
        {
            if (a % 2 == 0)
            { return true; }
            return false;
        }

        public static int Max(int a, int b, int c)
        {
            int d = Math.Max(Math.Max(a, b), c);
            return d;
        }

        public static long Giaithua(int a)
        {
            long gt = 1;
            if (a == 0 || a == 1)
                return 1;
            for (int i = 1; i <= a; i++)
            { gt = gt * i; }
            return gt;
        }

        public static string DaoChuoiKyTU(string a)
        {
            char[] b = a.ToCharArray();
            Array.Reverse(b);
            return new string(b);
        }

        public static bool Songuyento(int a)
        {
            if (a == 1 || a == 0)
            { return false; }
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                { return false; }

            }
            return true;
        }



        public static int NguyenAm(string s)
        {
            int a = 0;
            string ls = s.ToLower();
            foreach (char c in ls)
            {
                if (c == 'a' || c == 'e' || c == 'u' || c == 'i' || c == 'o')
                {
                    a++;
                }
            }
            return a;
        }

        public static double LuyThua(double x, int y)
        {
            double r = 1;
            if (x == 0)
            {
                return 0;
            }
            if (x == 1 || y == 0)
            {
                return 1;
            }
            for (int i = 1; i <= y; i++)
            {
                r *= x;
            }
            return r;
        }

        public static double DiemTrungBinh(int[] array)
        {
            if (array.Length == 0)
            { return 0; }
            double tong = 0;
            foreach (int i in array)
            {
                tong += i;
            }
            double tb = tong / array.Length;
            return tb;

        }

        public static bool ChuoiDoiXung(string a)
        {
            string b = DaoChuoiKyTU(a);
            if (b == a)
            { return true; }
            return false;
        }


        //Bài 1: Tính tổng hai số nguyên
        static void ex01()
        {
            Console.Write("Nhap so nguyen thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen thu hai: ");
            int b = int.Parse(Console.ReadLine());
            int tong = Tong(a, b);
            Console.WriteLine($"Tong cua hai so nguyen la {tong}");
        }


        //Bài 2: Kiểm tra số chẵn lẻ
        static void ex02()
        {
            Console.Write("Nhap so: ");
            int a = int.Parse(Console.ReadLine());
            if (KiemTraChanLe(a) == true)
            { Console.WriteLine("La so chan"); }
            else { Console.WriteLine("La so le"); }
        }


        //Bài 3: Tìm số lớn nhất trong ba số
        static void ex03()
        {
            Console.Write("Nhap ba so: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = Max(a, b, c);
            Console.WriteLine($"so lon nhat trong ba so la: {max}");

        }

        //Bài 4: Tính giai thừa của một số
        static void ex04()
        {
            Console.WriteLine("Nhap so can tinh: ");
            int a = int.Parse(Console.ReadLine());
            long l = Giaithua(a);
            Console.WriteLine(l);
        }

        //Bài 5: Đảo ngược chuỗi ký tự
        static void ex05()
        {
            Console.Write("Nhap chuoi: ");
            string a = Console.ReadLine();
            string b = DaoChuoiKyTU(a);
            Console.Write($"Chuoi sau khi dao la: {b}");
        }

        //Bài 6: Kiểm tra số nguyên tố
        static void ex06()
        {
            Console.Write("Nhap so de kiem tra: ");
            int a = int.Parse(Console.ReadLine());
            bool b = Songuyento(a);
            if (b = true)
            {
                Console.Write("La so nguyen to");

            }
            else { Console.WriteLine("Khong la so nguyen to"); }
        }

        //Bài 7: In dãy Fibonacci
        static void ex07()
        {
            Console.Write("Nhap so phan tu cho chuoi: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int d = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");
                d = a + b;
                a = b;
                b = d;
            }
        }

        //Bài 8: Đếm số lượng nguyên âm trong chuỗi
        static void ex08()
        {
            Console.Write("Nhap dong chu: ");
            string s = Console.ReadLine();
            int a = NguyenAm(s);
            Console.Write($"Co {a} nguyen am trong cau");
        }

        //Bài 9: Tính lũy thừa
        static void ex09()
        {
            Console.Write("Nhap co so: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhap so mu: ");
            int y = int.Parse(Console.ReadLine());
            double result = LuyThua(x, y);
            Console.WriteLine(result);
        }

        //Bài 10: Tính điểm trung bình của mảng
        static void ex10()
        {
            int[] mang = { 1, 2, 3, 4, 5, 6 };
            double tb = DiemTrungBinh(mang);
            Console.WriteLine($"Diem trung binh mang {{ 1, 2, 3, 4, 5, 6 }} la {tb}");
        }

        //Bai 11: Kiểm tra chuỗi đối xứng (Palindrome)
        static void ex11()
        {
            Console.Write("Nhap chuoi ki tu: ");
            string a = Console.ReadLine();
            bool c = ChuoiDoiXung(a);
            Console.WriteLine(c);
        }
        //Bài 12: Chuyển đổi nhiệt độ
        static double NhietDo(double a)
        {
            double b = 0;
            return b = 1.8 * a + 32;
        }

        static void ex12()
        {
            Console.Write("Nhap do C: ");
            double a = double.Parse(Console.ReadLine());
            double b = 0;
            b = NhietDo(a);
            Console.WriteLine($"Chuyen sang do F la: {b}");
        }

        //Bài 13: Tìm giá trị nhỏ nhất trong mảng
        static int Min(int[] arr)
        {
            int min = arr[0];
            foreach (int i in arr)
            { min = Math.Min(min, i); }
            return min;
        }

        static void ex13()
        {
            int[] arr = { 1, 2, 6, 10, 5, 7 };
            int min = Min(arr);
            Console.Write($"Gia tri nho nhat trong chuoi {{ 1, 2, 6, 10, 5, 7 }} la: {min}");
        }

        //Bài 14: Tính tổng các chữ số của một số nguyên
        static int TongChuSo(int a)
        {
            int tong = 0;
            while (a > 0)
            {
                tong += a % 10;
                a /= 10;
            }
            return tong;
        }

        static void ex14()
        {
            Console.Write("Nhap so: ");
            int a = int.Parse(Console.ReadLine());
            int sum = TongChuSo(a);
            Console.WriteLine($"Tong cac so co trong so la: {sum}");
        }

        //Bài 15: Sắp xếp mảng tăng dần
        static void ex15()
        {
            int[] array = { 1, 4, 6, 2, 6, 10, 23, 15 };
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                    }
                }
            }
            foreach (int b in array)
            { Console.Write(b + " "); }
            Console.WriteLine();
        }

        //Bài 16: Xóa ký tự trùng lặp
        static string XoaKyTu(string s)
        {
            string r = " ";
            foreach (char a in s)
            {
                if (r.IndexOf(a) == -1)
                {
                    r += a;
                }
            }
            return r;
        }

        static void ex16()
        {
            Console.Write("Nhap chuoi ky tu: ");
            string s = Console.ReadLine();
            string r = XoaKyTu(s);
            Console.WriteLine(r);
        }

        //Bài 17: Tìm ước chung lớn nhất (UCLN)
        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static void ex17()
        {
            Console.Write("Nhap hai so: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = UCLN(a, b);
            Console.WriteLine($"Uoc chung lon nhat cua hai so {a} va {b} la {c}");
        }

        //Bài 18: Chuyển đổi hệ thập phân sang nhị phân
        static string NhiPhan(int a)
        {
            if (a == 0)
            { return "0"; }
            string b = "";
            while (a > 0)
            {
                int c = a % 2;
                b = c + b;
                a /= 2;
            }
            return b;
        }

        static void ex18()
        {
            Console.Write("Nhap so: ");
            int a = int.Parse(Console.ReadLine());
            string b = NhiPhan(a);
            Console.WriteLine($"Tu he thap phan chuyen sang nhi phan la {b}");
        }

        //Bài 19: Kiểm tra năm nhuận
        static bool NamNhuan(int a)
        {
            if (a % 4 == 0 && a % 100 != 0 || a % 4 == 0)
            {
                return true;
            }
            return false;
        }

        static void ex19()
        {
            Console.Write("Nhap so nam: ");
            int a = int.Parse(Console.ReadLine());
            bool b = NamNhuan(a);
            if (b = true)
            {
                Console.WriteLine("La nam nhuan");
            }
            else { Console.WriteLine("Khong la nam nhuan"); }
        }

        //Bài 20: Đếm số từ trong câu
        static int DemSoTu(string s)
        {
            if (string.IsNullOrEmpty(s))
            { return 0; }
            string[] a = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return a.Length;
        }
        static void ex20()
        {
            Console.Write("Nhap cau: ");
            string s = Console.ReadLine();
            int a = DemSoTu(s);
            Console.WriteLine($"So tu co trong cau la {a}");

        }
    }
}
