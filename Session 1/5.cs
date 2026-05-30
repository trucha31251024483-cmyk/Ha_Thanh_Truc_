using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_1
{
    internal class _5
    {
        static void Maine(string[] args)
        {
            Console.WriteLine("Convert Celsius to Fahrenheit and vice versa");
            double C, F;
            Console.Write("Nhap Do C: ");
            C = double.Parse(Console.ReadLine());
            F = (C * 1.8) + 32;
            Console.WriteLine("Do F = " + F);
            Console.Write("Nhap Do F: ");
            F = double.Parse(Console.ReadLine());
            C = (F - 32) / 1.8;
            Console.WriteLine("Do C = " + C);
        }
    }
}
