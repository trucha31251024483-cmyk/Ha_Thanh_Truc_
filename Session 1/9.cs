using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_1
{
    internal class _9
    {
        static void Maini(string[] args)
        {
            Console.WriteLine("Calculate Area of Square");
            double a;
            Console.Write("Nhap canh: ");
            a = double.Parse(Console.ReadLine());
            double S = a * a;
            Console.WriteLine("Dien tich hinh vuong la: " + S);
        }
    }
}
