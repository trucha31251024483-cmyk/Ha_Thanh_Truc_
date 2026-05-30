using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _13
    {
        static void Main13(string[] args)
        {
            Console.WriteLine("Sum or Triple Sum of Integers");
            int a, b;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                int sum = (a + b) * 3;
                Console.WriteLine($"Ket qua la: {sum}");

            }
            else
            {
                int sum = a + b;
                Console.WriteLine($"Ket qua la: {sum}");

            }
        }
    }
}
