using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _15
    {
        static void Main15(string[] args)
        {
            Console.WriteLine("Convert String to Lowercase");
            Console.Write("Enter a string: ");
            string vao = Console.ReadLine();
            string ra = vao.ToLower();
            Console.WriteLine($"Lowercase: {ra}");
        }
    }
}
