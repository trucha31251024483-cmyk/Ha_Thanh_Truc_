 using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Session_3
{
    internal class BaiTHSlide
    {
        public static void Mainy(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //ex01();
            //ex02();
            //ex03();
            //ex04();
            //ex05();
            //ex06();
            //ex07();
            //ex08();
            //ex09();
            //ex10();
            //ex11();
            //ex12();
        }
        static void ex01()
        {
            Console.WriteLine("Check whether a given number is even or odd");
            int a;
            Console.Write("Nhập 1 số: ");
            a = int.Parse(Console.ReadLine());
            int kq = a % 2;
            if (kq == 0)
                Console.WriteLine($"{a} là số chẵn");
            else
                Console.WriteLine($"{a} là số lẻ");
        }

        static void ex02()
        {
            Console.WriteLine("Find the largest of three numbers");
            int a, b, c;
            Console.Write("Enter first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            c = int.Parse(Console.ReadLine());
            int max = Math.Max(a, Math.Max(b, c));
            Console.WriteLine($"The largest number is {max}");
        }


        static void ex03()
        {
            Console.WriteLine("Accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies");
            int x, y;
            Console.Write("Nhập tọa độ X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tọa độ Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine("Điểm nằm ở góc phần tư I");
            else if (x < 0 && y > 0)
                Console.WriteLine("Điểm nằm ở góc phần tư II");
            else if (x < 0 && y < 0)
                Console.WriteLine("Điểm nằm ở góc phần tư III");
            else if (x > 0 && y < 0)
                Console.WriteLine("Điểm nằm ở góc phần tư IV");
            else if (x == 0 && y == 0)
                Console.WriteLine("Điểm nằm ở góc tọa độ");
            else if (x == 0)
                Console.WriteLine("Điểm nằm trên trục tung");
            else Console.WriteLine("Điểm nằm trên trục hoành");
        }

        static void ex04()
        {
            Console.WriteLine("Check whether a triangle is Equilateral, Isosceles or Scalene");
            int a, b, c;
            Console.Write("Nhập cạnh a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập cạnh b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập cạnh c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a == b || b == c || c == a)
                Console.WriteLine("Đây là tam giác cân");
            else if (a == b && b == c)
                Console.WriteLine("Đây là tam giác đều");
            else
                Console.WriteLine("Đây là tam giác thường");
        }

        static void ex05()
        {
            Console.WriteLine("Read 10 numbers and find their average and sum");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Nhập số thứ {i}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            double avg = sum / 10.0;
            Console.WriteLine($"Tổng = {sum}");
            Console.WriteLine($"Trung bình = {avg}");
        }

        static void ex06()
        {
            Console.WriteLine("Display the multiplication table of a given integer");
            int a;
            Console.Write("Nhập 1 số: ");
            a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{a} x {i} = {a * i}");
            }
        }

        static void ex07()
        {
            Console.WriteLine("Display a pattern like triangles with a number");
            Console.Write("Nhập số hàng: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void ex08()
        {
            Console.WriteLine("Display the n terms of harmonic series and their sum");
            Console.Write("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i}");
                if (i < n)
                    Console.Write(" + ");
                sum = sum + 1.0 / i;
            }
            Console.WriteLine($"\nTổng = {sum}");
        }

        static void ex09()
        {
            Console.WriteLine("Find the ‘perfect’ numbers within a given number range");
            Console.Write("Nhập khoảng từ: ");
            int bd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Đến: ");
            int kt = Convert.ToInt32(Console.ReadLine());
            for (int n = bd; n <= kt; n++)
            {
                int sum = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                        sum = sum + i;
                }
                if (sum == n)
                    Console.WriteLine($"{n} là số hoàn hảo");
            }

        }

        static void ex10()
        {
            Console.WriteLine("Determine whether a given number is prime or not");
            Console.Write("Nhập số cần kiểm tra: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool snt = true;
            if (n < 2) snt = false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    snt = false;
                break;
            }
            if (snt == true)
                Console.WriteLine("Là số nguyên tố");
            else
                Console.WriteLine("Không phải là số nguyên tố");
        }

        static void ex11()
        {
            Console.Write("Nhập số hàng: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{num}");
                    num++;
                }
                Console.WriteLine();
            }
        }

        static void ex12()
        {
            Console.Write("Nhập số hàng: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{num} ");
                    num = num + 1;
                }
                Console.WriteLine();
            }
        }

    }
}
