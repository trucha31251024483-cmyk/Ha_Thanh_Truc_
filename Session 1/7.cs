using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_1
{
    internal class _7
    {
        static void Maing(string[] args)
        {
            Console.WriteLine("Print ASCII Value");
            Console.Write("Nhap 1 ky tu: ");
            char kt = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int ascii = (int)kt;
            Console.WriteLine($"Gia tri ASCII cua {kt} la: {ascii}");
        }
    }
}
