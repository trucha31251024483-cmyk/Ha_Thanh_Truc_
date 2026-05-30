using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_1
{
    internal class _10
    {
        static void Mainj(string[] args)
        {
            Console.WriteLine("Convert days to years, weeks and days");
            int d;
            Console.Write("Nhap so ngay: ");
            d = int.Parse(Console.ReadLine());
            int y = (d / 365);
            int w = (d % 365) / 7;
            int nd = (d % 365) % 7;
            Console.WriteLine($"{y} nam, {w} tuan, {nd} ngay");
        }
    }
}
