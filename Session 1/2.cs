using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_1
{
    internal class _2
    {
        static void Mainb(string[] args)
        {
            Console.WriteLine("Swap Values of Two Variables");
            int a, b;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a = {a}, b = {b}");
        }    
    }
}
