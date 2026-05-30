using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_3
{
    internal class _1
    {
        static void Mainh1()
        {
            Console.Write("Nhap so thu nhat: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap phep tinh (+, -, *, /): ");
            string c = Console.ReadLine();

            double result = 0;

            if (c == "+")
                result = a + b;
            else if (c == "-")
                result = a - b;
            else if (c == "*")
                result = a * b;
            else if (c == "/")
                result = a / b;

            Console.WriteLine("Ket qua: " + result);
        }
    }
}
