using System;
using System.Collections.Generic;
using System.Text;

namespace Ha_Thanh_Truc_.Sesson_5
{
    internal class BTslide
    {
        static void Main6(string[] args)
        {
            ex01();
        }
        /// <summary>
        /// Tạo một ma trận kích thước ngẫu nhiên 
        /// </summary>
        /// <param name="r">dòng</param>
        /// <param name="c">cột</param>
        /// <returns></returns>
        static int[,] TaoMatran( int r, int c)
        {
            int[,] arr = new int[r, c];
            Random random = new Random();
            for (int i = 0; i<r; i++)
            {
                for (int j = 0; j< c; j++)
                {
                    arr[i, j] = random.Next(0, 100);

                }
            }
            return arr;
        }

        static int[,] TaoMang(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]}\t");
                }
                Console.WriteLine();
            }
            return arr;

        }


        static void Indong(int[,] arr, int rows)
        {
            for (int i =0;i<arr.GetLength(1);i++)
            {
                Console.Write($"{arr[rows,i]}\t");
            }
            
        }
        static void ex01()
        {
            Console.Write("Nhap so dong: "); int r = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: "); int c = int.Parse(Console.ReadLine());
            int[,] array = TaoMatran(r, c);
            int[,] arr = TaoMang(array);
            Console.Write("Nhap dong can in: "); int n = int.Parse(Console.ReadLine());
            Indong(arr, n - 1);
            Console.ReadLine();
        }

       
    }
}
