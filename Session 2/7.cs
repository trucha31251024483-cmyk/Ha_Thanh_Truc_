using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _7
    {
        static void Main7(string[] args)
        {
            Console.WriteLine("Multiplication Table");
            int a;
            Console.Write("Nhap mot so: ");
            a = int.Parse(Console.ReadLine());
            for (int n = 0; n <= 10; n++)
            {
                Console.WriteLine($"{a} * {n} = {a * n}");
            }

        }
    }
}
