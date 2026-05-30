using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _6
    {
        static void Main6(string[] args)
        {
            Console.WriteLine(" Arithmetic Operations ");
            float a, b;
            Console.Write("Nhap a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");

        }
    }
}
