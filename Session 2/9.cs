using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _9
    {
        static void Main9(string[] args)
        {
            Console.WriteLine("Specified Formula with Three Numbers");
            float x, y, z;
            Console.Write("Nhap x: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = float.Parse(Console.ReadLine());
            Console.Write("Nhap z: ");
            z = float.Parse(Console.ReadLine());
            Console.WriteLine($"({x} + {y}) * {z} = {(x + y) * z}");
            Console.WriteLine($"{x} * {y} + {y} * {z} = {x * y + y * z}");
        }
    }
}
