using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_1
{
    internal class _3
    {
        static void Mainc(string[] args)
        {
            Console.WriteLine("Multiply two Floating Point Numbers");
            float a, b;
            Console.Write("Nhap a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = float.Parse(Console.ReadLine());
            float result = a * b;
            Console.WriteLine("Tich = " + result);
        }
    }
}
