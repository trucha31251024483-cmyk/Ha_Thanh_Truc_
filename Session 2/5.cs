using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _5
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("Multiply Three Numbers");
            int a, b, c;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = int.Parse(Console.ReadLine());
            int Tich = a * b * c;
            Console.WriteLine("Tich ba so la: " + Tich);
        }
    }
}
