using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ha_Thanh_Truc_.BAI_6
{
    internal class _2
    {
        public static void Main4(string[] args)
        {
            //ex01();
            //ex02();
            //ex03();
            ////ex04();
            //ex05();
            //ex06();
            //ex07();
            //ex08();
            //ex09();
            ex10();
        }

        //Bài 1: Tính giá trị trung bình của các phần tử trong mảng.
        static double TrungBinh(int[] array)
        {
            if (array.Length == 0)
            { return 0; }
            int tong = 0;
            foreach (int i in array)
            {
                tong += i;
            }
            double tb = (double)tong / array.Length;
            return tb;
        }
        static void ex01()
        {
            Console.Write("Nhap so phan tu cua day: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            double tb = TrungBinh(array);
            Console.Write($"Gia tri trung binh cua day la: {tb}");

        }

        //Bài 2: Kiểm tra xem mảng có chứa một giá trị cụ thể nào đó hay không.
        static bool GiaTri(int[] array, int n)
        {
            foreach (int i in array)
            {
                if (i == n)
                { return true; }
            }
            return false;
        }

        static void ex02()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int a = int.Parse(Console.ReadLine());
            int[] array = new int[a];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhap so bat ki: ");
            int b = int.Parse(Console.ReadLine());
            bool r = GiaTri(array, b);
            if (r == true)
            { Console.WriteLine("Co chua gia tri trong mang"); }
            else { Console.WriteLine("Khong chua gia tri trong mang"); }
        }

        //Bài 3: Tìm vị trí (chỉ số/index) của một phần tử trong mảng.

        static int ChiSo(int[] array, int n)
        {
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == n)
            //    { return i; }
            //}
            //return -1;
            int a = Array.IndexOf(array, n);
            return a;
        }

        static void ex03()
        {
            Console.Write("Nhap so phan tu cho mang: ");
            int a = int.Parse(Console.ReadLine());
            int[] array = new int[a];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhap so can tim chi so: ");
            int b = int.Parse(Console.ReadLine());
            int r = ChiSo(array, b);
            if (r == -1)
            { Console.WriteLine("Phan tu nay khong ton tai trong mang"); }
            else { Console.WriteLine($"{b} co chi so {r}"); }
        }

        //Bài 4: Xóa phần tử cụ thể ra khỏi mảng
        static int[] XoaPhanTu(int[] array, int n)
        {
            int trung = 0;
            foreach (int i in array)
            {
                if (i == n)
                {
                    trung++;
                }
            }

            int j = 0;
            int[] arr = new int[array.Length - trung];
            foreach (int i in array)
            {
                if (i == n)
                {
                    continue;
                }
                else
                {
                    arr[j] = i;
                    j++;
                }
            }
            return arr;
        }

        static void ex04()
        {
            Console.Write("Nhap so phan tu cho mang: ");
            int a = int.Parse(Console.ReadLine());
            int[] array = new int[a];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhap phan tu can xoa: ");
            int b = int.Parse(Console.ReadLine());
            int[] r = XoaPhanTu(array, b);
            Console.WriteLine($"Mang moi se la {string.Join(", ", r)}");
        }

        //Bài 5: Tìm giá trị lớn nhất, nhỏ nhất cuả mảng
        static int Max(int[] array)
        {
            int max = array[0];
            foreach (int i in array)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            return max;
        }
        static int Min(int[] array)
        {
            int min = array[0];
            foreach (int i in array)
            {
                if (min > i)
                {
                    min = i;
                }
            }
            return min;
        }

        static void ex05()
        {
            Console.Write("Nhap so phan tu cho mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int max = Max(array);
            Console.WriteLine($"Max cua mang la: {max}");
            int min = Min(array);
            Console.WriteLine($"Min cua mang la: {min}");
        }


        //Bài 6: Đảo ngược các mảng số nguyên 
        static int[] DaoNguoc(int[] array)
        {
            Array.Reverse(array);
            return array;
        }

        static void ex06()
        {
            Console.Write("Nhap so phan tu cho mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] arr = DaoNguoc(array);
            Console.Write($"Mang sau khi dao nguoc la {string.Join(", ", arr)}");
        }

        //Bài 7: Tìm các giá trị bị trùng lặp trong mảng
        //static int[] TrungLap(int[] array)
        //{
        //    Array.Sort(array);
        //    int j = 0;
        //    int[] arr = new int[array.Length];
        //    for (int i = 0;i< array.Length-1;i++)
        //    {
        //        if (array[i] == array[i+1])
        //        {
        //            if (j==0 || arr[j-1] != array[i])
        //            {
        //                arr[j] = array[i];
        //                j++;
        //            }
        //        }
        //    }
        //    int[] ar = new int[j];
        //    for (int i = 0; i < j; i++)
        //    {
        //        ar[i] = arr[i];
        //    }
        //    return ar;
        //}

        //static void ex07()
        //{
        //    Console.Write("Nhap so phan tu cho mang: ");
        //    int n = int.Parse(Console.ReadLine());
        //    int[] array = new int[n];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write($"Nhap phan tu thu {i + 1}: ");
        //        array[i] = int.Parse(Console.ReadLine());
        //    }
        //    int[] arr = TrungLap(array);
        //    if (arr.Length == 0)
        //    { Console.WriteLine("Khong co phan tu trung lap"); }
        //    else
        //    {
        //        Console.WriteLine($"Cac phan tu trung lap la {string.Join(", ", arr)}");
        //    }
        //}

        static int[] timgiatritrunglap(int[] arr)
        {
            int[] mangtam = new int[arr.Length];
            int soluongtrung = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        bool dainchua = false;
                        for (int k = 0; k < i; k++)
                        {
                            if ((arr[k] == arr[i]))
                                dainchua = true;
                            break;

                        }
                        if (dainchua == false)
                        {
                            mangtam[soluongtrung] = arr[i];
                            soluongtrung++;
                        }
                        break;

                    }

                }
            }
            int[] mangkq = new int[soluongtrung];
            for (int i = 0; i < soluongtrung; i++)
            {
                mangkq[i] = mangtam[i];
            }
            return mangkq;
        }
        static void inmangtrunglap(int[] mangtrunglap)
        {
            if (mangtrunglap.Length == 0)
                Console.WriteLine("Khong co phan tu trung lap");
            else
            {
                Console.Write($"Cac phan tu trung lap la: ");
                for (int i = 0; i < mangtrunglap.Length; i++)
                {
                    Console.Write($"{mangtrunglap[i]} ");
                }
            }
        }
        static void ex07()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap gia tri cua phan tu thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            int[] kq = timgiatritrunglap(mang);

            inmangtrunglap(kq);
        }


        //Bài 8: Loại bỏ các phần tử trùng lặp khỏi một mảng.
        static int[] LoaiTrung(int[] array)
        {

            int j = 0;
            int[] arr = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                bool k = false;
                for (int h = 0; h < i; h++)
                {
                    if (array[h] == array[i])
                    {
                        k = true;
                        break;
                    }
                }
                if (k == false)
                {
                    arr[j] = array[i];
                    j++;
                }
            }

            int[] ar = new int[j];
            for (int n = 0; n < j; n++)
            {
                ar[n] = arr[n];
            }
            return ar;
        }

        static void ex08()
        {
            Console.Write("Nhap so phan tu cho mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] arr = LoaiTrung(array);
            if (arr.Length == array.Length)
            { Console.WriteLine("Khong co phan tu trung lap"); }
            else { Console.WriteLine($"Mang sau khi loai bo trung lap la {string.Join(", ", arr)}"); }
        }

        //Bài 9: Yêu cầu người dùng nhập 10 số nguyên và sắp xếp chúng bằng cách triển khai thuật toán Bubble Sort (sắp xếp nổi bọt).
        static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

       static void ex09()
        {
            Console.WriteLine("Nhap 10 phan tu cho mang");
            int n = 10;
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] arr = BubbleSort(array);
            Console.WriteLine($"Mang sau khi sap xep la: {string.Join(", ",arr)}");
            Console.ReadLine();
        }

        //Bài 10: Yêu cầu người dùng nhập một câu, sau đó yêu cầu nhập một từ. Tìm kiếm xem từ đó có xuất hiện trong câu hay không bằng cách sử dụng thuật toán tìm kiếm tuyến tính (linear search).
        static bool TimTu(string cau, string tu)
        {
            string[] arr = tu.Split(' ');
            bool r = false;
            for (int i = 0; i<arr.Length;i++)
            {
                if (arr[i].Equals(cau, StringComparison.OrdinalIgnoreCase))
                {
                    r = true;
                }
            }
            return r;
        }

        static void ex10()
        {
            Console.Write("Nhap cau: ");
            string a = Console.ReadLine();
            Console.Write("Nhap tu: ");
            string b = Console.ReadLine();
            bool r = TimTu(a, b);
            if (r = true)
            {
                Console.WriteLine($"Tu {b} co xuat hien trong cau");
            }
            else { Console.WriteLine($"Tu {b} khong xuat hien trong cau"); }
        }
    }
}

