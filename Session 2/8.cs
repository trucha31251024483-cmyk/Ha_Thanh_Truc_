using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _8
    {
        static void Main8(string[] args)
        {
            Console.WriteLine("Average of Four Numbers");
            float a, b, c, d;
            Console.Write("Nhap a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = float.Parse(Console.ReadLine());
            Console.Write("Nhap d: ");
            d = float.Parse(Console.ReadLine());
            float avg = (a + b + c + d) / 4;
            Console.WriteLine($"Trung binh cua {a}, {b}, {c}, {d} la: {avg}");
        }
    }
}
