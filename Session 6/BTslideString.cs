using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_6
{
    internal class BTslideString
    {
        static void Main7(string[] args)
        {
            //ex01();
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

        }

        //Bài 1: Nhập vào một chuỗi và in chuỗi đó ra mh
        static void ex01()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            Console.WriteLine(s);
        }

        //Bài 2: Tìm độ dài của chuỗi
        static int DoDaiChuoi(string s)
        {
            int count = 0;
            if (s == "")
            { return 0; }
            foreach (char i in s)
            {
                count++;
            }
            return count;
        }

        static void ex02()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            int c = DoDaiChuoi(s);
            Console.Write($"Do dai cua chuoi la {c}");
        }

        //Bài 3: Tách các chữ riêng biệt ra khỏi chuỗi
        static string[] TachChu(string s)
        {
            char[] tu = new char[] { ' ' };
            string[] cactu = s.Split(tu, StringSplitOptions.RemoveEmptyEntries);
            return cactu;
        }

        static void InMang(string[] cactu)
        {
            foreach (string tu in cactu)
            { Console.WriteLine(tu); }
        }

        static void ex03()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            string[] a = TachChu(s);
            Console.WriteLine($"Cac ky tu sau khi tach la: ");
            InMang(a);
        }

        //Bài 4: Tách các kí tự riêng biệt ra khỏi chuỗi

        static void TachKyTu(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine($"{s[i]}");
            }
            
        }
        static void ex04()
        {
            Console.Write("Nhap chuoi ki tu: ");
            string s = Console.ReadLine();
            TachKyTu(s);
        }

        //Bài 5: In các chuỗi kí tự theo thứ tự đảo ngược
        static void InChuoiDaoNguoc(string s)
        {
           for (int i = s.Length-1; i>=0; i--)
           { 
                Console.Write($"{s[i]}");
           }
        }

        static void ex05()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            InChuoiDaoNguoc(s);
        }

        //6. Viết chương trình đếm số lượng chữ cái, chữ số và ký tự đặc biệt trong một chuỗi.
        static int[] demkytu(string chuoi)
        {
            int[] tong = new int[3];
            tong[0] = 0; //chu cai
            tong[1] = 0; // so
            tong[2] = 0; // ky tu dac biet
            for (int i = 0; i < chuoi.Length; i++)
            {
                char c = chuoi[i];
                if (char.IsLetter(c))
                    tong[0]++;
                else if (char.IsDigit(c))
                    tong[1]++;
                else if (c != ' ')
                    tong[2]++;
            }
            return tong;
        }
        static void ex06()
        {
            Console.Write("Nhap mot chuoi: ");
            string s = Console.ReadLine();
            int[] kq = demkytu(s);
            Console.Write($"So chu cai trong chuoi la: {kq[0]}" +
                $"\nSo chu so trong chuoi la: {kq[1]}" +
                $"\nSo ky tu dac biet trong chuoi la: {kq[2]}");
        }

        //7. Viết chương trình đếm số nguyên âm và phụ âm trong một chuỗi.
        static int[] demnguyenamphuam(string chuoi)
        {
            int[] tong = new int[2];
            tong[0] = 0;
            tong[1] = 0;
            if (string.IsNullOrEmpty(chuoi))
                return tong;

            for (int i = 0; i < chuoi.Length; i++)
            {
                char c = chuoi[i];
                if (char.IsLetter(c))
                {
                    char chu = char.ToLower(c);
                    if (c == 'u' || c == 'e' || c == 'o' || c == 'a' || c == 'i')
                        tong[0]++;
                    else tong[1]++;
                }

            }
            return tong;


        }
        static void ex07()
        {
            Console.Write("Nhap mot chuoi: ");
            string s = Console.ReadLine();
            int[] kq = demnguyenamphuam(s);
            Console.Write($"So phu am trong chuoi la: {kq[0]}" +
                $"\nSo nguyen am trong chuoi la: {kq[1]}");
        }

        //8. Viết chương trình kiểm tra xem một chuỗi con có xuất hiện trong chuỗi đã cho hay không.
        static bool kiemtrachuoi(string chuoi, string chuoicon)
        {
            if (string.IsNullOrEmpty(chuoicon)) return true;
            if (string.IsNullOrEmpty(chuoi) || chuoicon.Length > chuoi.Length) return false;
            string ch = chuoi.ToLower();
            string chcon = chuoicon.ToLower();
            for (int i = 0; i <= ch.Length - chcon.Length; i++)
            {
                string doancat = ch.Substring(i, chcon.Length);
                if (doancat.Equals(chcon))
                    return true;
            }
            return false;
        }
        static void ex08()
        {
            Console.Write("Nhap mot chuoi: ");
            string s1 = Console.ReadLine();
            Console.Write("Nhap chuoi can tim: ");
            string s2 = Console.ReadLine();
            bool kq = kiemtrachuoi(s1, s2);
            if (kq)
                Console.WriteLine("Co xuat hien");
            else Console.WriteLine("Khong xuat hien");
        }

        //9. Viết chương trình tìm vị trí của một chuỗi con trong chuỗi.
        static int timvitri(string chuoi, string chuoicon)
        {
            if (string.IsNullOrEmpty(chuoicon)) return 0;
            if (string.IsNullOrEmpty(chuoi) || chuoicon.Length > chuoi.Length) return -1;
            string ch = chuoi.ToLower();
            string chcon = chuoicon.ToLower();
            for (int i = 0; i < ch.Length - chcon.Length; i++)
            {
                string doancat = ch.Substring(i, chcon.Length);
                if (doancat.Equals(chcon) == true)
                    return i;

            }
            return -1;
        }
        static int timvitri1(string chuoi, string chuoicon)
        {
            if (string.IsNullOrEmpty(chuoi) || chuoi.Length < chuoicon.Length) return -1;
            return chuoi.IndexOf(chuoicon, StringComparison.OrdinalIgnoreCase);
        }
        static void ex09()
        {
            Console.Write("Nhap mot chuoi: "); string s1 = Console.ReadLine();
            Console.Write("Nhap chuoi con can tim vi tri: "); string s2 = Console.ReadLine();
            int kq = timvitri(s1, s2);
            if (kq == -1)
                Console.WriteLine("Khong tim thay");
            else Console.Write($"Xuat hien tu vi tri: {kq}");
        }

        //10. Viết chương trình kiểm tra một ký tự có phải là chữ cái hay không, và nếu đúng thì kiểm tra đó là chữ hoa hay chữ thường.
        static int kiemtrakytu(char kytu)
        {
            if (!char.IsLetter(kytu)) return 0;
            if (char.IsUpper(kytu)) return 1;
            else return 2;
        }
        static void ex10()
        {
            Console.Write("Nhap 1 ky tu can kiem tra: ");
            char a = char.Parse(Console.ReadLine());
            int kq = kiemtrakytu(a);
            if (kq == 0)
                Console.WriteLine("Day khong phai chu cai");
            else if (kq == 1)
                Console.WriteLine("Day la chu cai viet hoa");
            else if (kq == 2)
                Console.WriteLine("Day la chu cai viet thuong");
        }

        //11. tìm số lần một chuỗi con xuất hiện trong một chuỗi cho trước
        static int timsolanxuathienchuoicon(string s, string c)
        {
            if (string.IsNullOrEmpty(c)) return 0;
            if (string.IsNullOrEmpty(s) || s.Length < c.Length) return -1;
            string chuoi = s.ToLower();
            string chuoicon = c.ToLower();
            int dem = 0;
            for (int i = 0; i <= chuoi.Length - chuoicon.Length; i++)
            {
                string doancat = chuoi.Substring(i, chuoicon.Length);
                if (doancat.Equals(chuoicon))
                {
                    dem++;
                }
            }
            return dem;
        }
        static void ex11()
        {
            Console.Write("Nhap mot chuoi: ");
            string a = Console.ReadLine();
            Console.Write("Nhap mot chuoi con can tim: ");
            string b = Console.ReadLine();
            int kq = timsolanxuathienchuoicon(a, b);
            if (kq == 0) Console.WriteLine($"{b} khong xuat hien trong chuoi");
            else if (kq == -1) Console.WriteLine("Loi chuoi");
            else Console.Write($"So lan chuoi {b} xuat hien la: {kq}");

        }

        //12. chèn một chuỗi con trước lần xuất hiện đầu tiên của một chuỗi.
        static string chenchuoi(string chuoigoc, string chuoilammoc, string chuoichen)
        {
            if (string.IsNullOrEmpty(chuoigoc) || string.IsNullOrEmpty(chuoilammoc) || string.IsNullOrEmpty(chuoichen))
                return chuoigoc;
            if (!chuoichen.EndsWith(" "))
                chuoichen = chuoichen + " ";
            int vitri = chuoigoc.IndexOf(chuoilammoc, StringComparison.Ordinal);
            if (vitri != -1)
            {
                return chuoigoc.Insert(vitri, chuoichen);
            }
            return chuoigoc;

        }
        static void ex12()
        {
            Console.Write("Nhap chuoi: ");
            string a = Console.ReadLine();
            Console.Write("Nhap chuoi lam moc: ");
            string b = Console.ReadLine();
            Console.Write("Nhap chuoi can chen truoc chuoi lam moc: ");
            string c = Console.ReadLine();
            string kq = chenchuoi(a, b, c);
            Console.Write($"Chuoi sau khi chen: {kq}");
        }

        //13. so sánh hai chuỗi mà không sử dụng các hàm thư viện chuỗi
        static int sosanhchuoi(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2)) return 0;
            if (string.IsNullOrEmpty(s1)) return -1;
            if (string.IsNullOrEmpty(s2)) return 1;
            int dodaingannhat = s1.Length;
            if (s2.Length < dodaingannhat)
                dodaingannhat = s2.Length;
            for (int i = 0; i < dodaingannhat; i++)
            {
                if (s1[i] != s2[i])
                {
                    return s1[i] - s2[i];
                }
            }
            return s1.Length - s2.Length;
        }
        static void ex13()
        {
            Console.Write("Nhap chuoi 1: ");
            string a = Console.ReadLine();
            Console.Write("Nhap chuoi 2: ");
            string b = Console.ReadLine();
            int kq = sosanhchuoi(a, b);
            if (kq == 0) Console.WriteLine("2 chuoi bang nhau");
            else if (kq > 0) Console.WriteLine("Chuoi 1 lon hon chuoi 2");
            else Console.WriteLine("Chuoi 1 nho hon chuoi 2");
        }


    }
}

        
    
