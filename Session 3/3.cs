using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_3
{
    internal class _3
    {
        static void Maina3(string[] args)
        {
            Console.Write("Nhap quang duong: ");
            double d = double.Parse(Console.ReadLine());

            Console.Write("Nhap gio: ");
            int h = int.Parse(Console.ReadLine());

            Console.Write("Nhap phut: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Nhap giay: ");
            int s = int.Parse(Console.ReadLine());

            double t = h + m / 60.0 + s / 3600.0;

            double km = d / t;
            double mile = (d * 0.621371) / t;

            Console.WriteLine("km/h = " + km);
            Console.WriteLine("miles/h = " + mile);
        }
    }
}
