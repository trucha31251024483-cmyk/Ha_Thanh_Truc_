using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_3
{
    internal class _2
    {
        static void Maina2(string[] args)
        {
            Console.WriteLine("y\t x");

            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"{y}\t {x}");
            }
        }
    }
}
