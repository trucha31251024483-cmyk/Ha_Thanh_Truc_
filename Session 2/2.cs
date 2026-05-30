using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Sum of Two Numbers");
            int a, b;
            Console.Write("Nhap so dau tien: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Tong hai so la: " + sum);
        }
    }
}
