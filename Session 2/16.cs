using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _16
    {
        static void Main16(string[] args)
        {
            Console.WriteLine("Hexadecimal to Decimal");
            Console.Write("Hexadecimal number: ");
            string hex = Console.ReadLine();
            int dec = Convert.ToInt32(hex, 16);
            Console.WriteLine($"Decimal number: {dec}");
        }
    }
}
