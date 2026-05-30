using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_1
{
    internal class _4
    {
        static void Maind(string[] args)
        {
            Console.WriteLine("convert feet to meter");
            double feet;
            Console.Write("Nhap so feet: ");
            feet = double.Parse(Console.ReadLine());
            double meter = feet * 0.3048;
            Console.WriteLine($"Met = {meter}");
        }
    }
}
