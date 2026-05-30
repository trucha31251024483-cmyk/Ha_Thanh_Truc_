using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _20
    {
        static void Main20(string[] args)
        {
            Console.WriteLine("Largest and Lowest of Three Integers");
            int a, b, c;
        Console.Write("Input first integer: ");
            a = int.Parse(Console.ReadLine());
        Console.Write("Input second integer: ");
            b = int.Parse(Console.ReadLine());
        Console.Write("Input third integer: ");
            c = int.Parse(Console.ReadLine());
        int max = Math.Max(a, Math.Max(b, c));
        int min = Math.Min(a, Math.Min(b, c));
        Console.WriteLine($"Largest of three: {max}");
            Console.WriteLine($"Lowest of three: {min}");

        }
}
}
