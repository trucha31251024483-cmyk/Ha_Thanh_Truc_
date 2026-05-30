using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_1
{
    internal class _8
    {
        static void Mainh(string[] args)
        {
            Console.WriteLine("Calculate Area of Circle");
            double r;
            Console.Write("Nhap ban kinh: ");
            r = double.Parse(Console.ReadLine());
            double dt = Math.PI * r * r;
            Console.WriteLine("Dien tich hinh tron la: " + dt);
        }
    }
}
