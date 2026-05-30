using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _4
    {
        static void Main4(string[] args)
        {
            Console.WriteLine(" Swap Two Numbers");
            int a, b;
            Console.Write("Nhap so dau tien: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Sau khi doi: ");
            Console.WriteLine(
                $"\t So dau tien la: {a}" +
                $"\t So thu hai la: {b}");

        }
    }
}
