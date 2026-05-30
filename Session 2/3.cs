using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _3
    {
        static void Main3(string[] args)
        {
            Console.WriteLine(" Divide Two Numbers ");
            float a, b;
            Console.Write("Nhap a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = float.Parse(Console.ReadLine());
            float thuong = a / b;
            Console.WriteLine("Ket qua la: " + thuong);
        }

    }
}
