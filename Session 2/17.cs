using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _17
    {
        static void Main17(string[] args)
        {
            Console.WriteLine("Check Multiple of 3 or 7");
            int a;
            Console.Write("Nhap mot so: ");
            a = int.Parse(Console.ReadLine());
            bool kq = ((a % 3 == 0) || (a % 7 == 0));
            Console.WriteLine($"Ket qua: {kq}");

        }
    }
}
