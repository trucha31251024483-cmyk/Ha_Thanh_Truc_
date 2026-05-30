using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _12
    {
        static void Main12(string[] args)
        {
            Console.WriteLine("Check Positive and Negative Pair");
            int a, b;
            Console.Write("Input first integer: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input second integer: ");
            b = int.Parse(Console.ReadLine());
            bool kq = (a < 0 && b > 0 || a > 0 && b < 0);
            Console.WriteLine($"Check if one is negative and one is positive: {kq}");

        }
    }
}
