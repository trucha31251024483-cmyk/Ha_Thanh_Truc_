using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _14
    {
        static void Main14(string[] args)
        {
            Console.WriteLine("Check for 20 or Sum Equals 20");
            int a, b;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            int sum = a + b;
            bool kq = ((a == 20) || (b == 20) || (sum == 20));
            Console.WriteLine($"Ket qua la: {kq}");

        }
    }
}
