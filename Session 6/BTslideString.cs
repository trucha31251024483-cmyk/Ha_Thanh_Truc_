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
            ex05();
            //ex06();
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
    }
}

        
    
