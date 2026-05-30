using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_2
{
    internal class _11
    {
        static void Main11(string[] args)
        {
            Console.WriteLine(" Celsius to Kelvin and Fahrenheit ");
            float a;
            Console.Write("Nhap do C: ");
            a = float.Parse(Console.ReadLine());
            float dok = a + 273f;
            float dof = (a * 1.8f) + 32f;
            Console.WriteLine($"\t Kelvin: {dok} \n" +
                $"\t Fahrenheit: {dof} \n");
        }
    }
}
