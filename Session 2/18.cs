using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _18
    {
        static void Main18(string[] args)
        {
            Console.WriteLine("Check Numbers Less than 100 & Greater than 200");
            double a, b;
            Console.Write("Nhap so dau tien: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            b = double.Parse(Console.ReadLine());
            bool kq = (((a < 100) && (b > 200)) || ((a > 200) && (b < 100)));
            Console.WriteLine($"Ket qua la: {kq}");
        }
    }
}
