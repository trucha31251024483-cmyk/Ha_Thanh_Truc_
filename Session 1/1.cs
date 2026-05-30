using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_1
{
    internal class _1
    {
        static void Maina(string[] args)
        {
            Console.WriteLine("Add / Sum Two Numbers");
            int a, b;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Tong = " + sum);
        }
    }
}
