using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_3
{
    internal class _5
    {
        static void Maina5(string[] args)
        {
            Console.Write("Nhap 1 ky tu: ");
            char c = char.Parse(Console.ReadLine());

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.WriteLine("Nguyen am");
            }
            else if (c >= '0' && c <= '9')
            {
                Console.WriteLine("Chu so");
            }
            else
            {
                Console.WriteLine("Ky hieu khac");
            }
        }
    }
}
