using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Ha_Thanh_Truc_.Session_7
{
    internal class _1
    {

        //1.to create a blank file on the disk.
        private static void TaoFileTrong(string file)
        {
            if (File.Exists(file))
            { Console.WriteLine("File da ton tai truoc do"); }
            else
            {
                using (File.Create(file)) ;
                Console.WriteLine("Da tao File moi");
            }
        }

        public static void Main1(string[] args)
        {
            string tenfile = "File.txt";
            TaoFileTrong(tenfile);
            string duongdan = Path.GetFullPath(tenfile);
            Console.WriteLine(duongdan);
            Console.ReadKey();
        }

        //2.to remove a file from the disk.
        static void XoaTapTin(string tenfile)
        {       
            try
            {
                if (File.Exists(tenfile))
                {
                    File.Delete(tenfile);
                    Console.WriteLine("Chuc mung, da xoa file thanh cong");
                }
                else { Console.WriteLine("Khong tim thay file"); }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Loi");
                Console.WriteLine("Chi tiet loi: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi");
                Console.WriteLine("Chi tiet loi: "+ex.Message);
            }
            
        }

        static void Main2(string[] args)
        {
            string filecanxoa = "File.txt";
            XoaTapTin(filecanxoa);
            Console.ReadKey();
        }

        //3.to create a file and add some text.
        private static void TaoFileVaViet(string file,string noidungthem, int a)
        {        
            try
            {
                if (a == 1)
                {
                    using (StreamWriter them = new StreamWriter(file, true, Encoding.UTF8))
                    {
                        them.WriteLine(noidungthem);
                    }
                    Console.WriteLine("Da them noi dung vo file");
                }
                else if (a == 2)
                {
                    using (StreamWriter them = new StreamWriter(file, false, Encoding.UTF8))
                    {
                        them.WriteLine(noidungthem);

                    }
                    Console.WriteLine("Da them noi dung de len file");
                }
                else 
                {  
                    Console.WriteLine("Ban chon sai r, chon lai di");
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi");
                Console.WriteLine("Chi tiet loi: "+ex.Message);
            }
            
        }

        static void Main3(string[] args)
        {
            string tenfile = "Cau3.txt";
            Console.Write("Vui long nhap noi dung muon them: ");
            string noidungthem = Console.ReadLine();
            Console.WriteLine("\n--- MENU LUA CHON ---");
            Console.WriteLine("Phim 1: Tiep tuc them vo file cu (Ghi noi duoi)");
            Console.WriteLine("Phim 2: File cu se bi xoa va ghi lai moi (Ghi de)");
            Console.Write("Vui long chon so 1 hoac 2: ");
            int a = int.Parse(Console.ReadLine());
            TaoFileVaViet(tenfile,noidungthem,a);
            string duongdan = Path.GetFullPath(tenfile);
            Console.WriteLine(duongdan);
            Console.ReadKey();
        }

        //4.create a text file and read it.
        private static void DocFile(string file)
        {
            if (File.Exists(file))
            {
                try 
                {
                    using (StreamReader doc = new StreamReader(file))
                    {
                        string line;
                        while ( (line=doc.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Loi");
                    Console.WriteLine(ex.Message);
                }
            }
            else { Console.WriteLine("File nay khong ton tai"); }
        }

        public static void Main4(string[] args)
        {
            string file = "Cau3.txt";
            DocFile(file);
            Console.ReadKey();
        }

        //5.to create a file and write an array of strings to the file.
        private static void TaoFileVaGhi(string file)
        {
            Console.Write("Nhap so dong muon nhap: ");
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = Console.ReadLine(); 
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(file))
                {
                    foreach (string b in array)
                    { sw.WriteLine(b); }
                    Console.WriteLine("Da them cac cau vao file");
                }
            }
            catch (Exception ex)
            { Console.WriteLine("Loi");
                Console.WriteLine("Chi tiet: " + ex.Message);
            }
        }

        public static void Main5(string[] args)
        {
            string file = "Cau5.txt";
            TaoFileVaGhi(file);
            string path = Path.GetFullPath(file);
            Console.WriteLine(path);
            Console.ReadKey();
        }

        //6.to append some text to an existing file.
        private static void ChenThem(string file)
        {
            try
            {
                Console.Write("Nhap so dong ban muon chen them: ");
                int n = int.Parse(Console.ReadLine());
                string[] array = new string[n];
                for (int i = 0; i<n; i++ )
                {
                    Console.Write($"Nhap phan tu thu {i+1}: ");
                    array[i] = Console.ReadLine();
                }
                
                using (StreamWriter sw = new StreamWriter(file,true,Encoding.UTF8))
                {
                    foreach (string b in array)
                    { sw.WriteLine(b); }
                    Console.WriteLine("Da them vao file");
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        public static void Main(string[] args)
        {
            string file = "Cau5.txt";
            ChenThem(file);
            string path = Path.GetFullPath(file);
            Console.WriteLine(path);
        }
        //7.tạo và sao chép tệp sang tên khác và hiển thị nội dung.
        static void saochepvahienthi(string path, string copy)
        {
            if (!File.Exists(path))
                File.Create(path);

            try
            {
                string[] idol = new string[]
                {
                    "Martin",
                    "Juhoon",
                    "James",
                    "Seonghyeon",
                    "Keonho"
                };
                File.WriteAllLines(path, idol);
                File.Copy(path, copy, true);
                Console.WriteLine("Da sao chep thanh cong");
                //string noidung = File.ReadAllText(copy);
                using (StreamReader sr = new StreamReader(copy))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Main7(string[] args)
        {
            string file = "idol.txt";
            string filecopy = "member.txt";
            saochepvahienthi(file, filecopy);
        }

        //8.tạo một tệp và di chuyển nó vào cùng thư mục với một tên khác.

        static void dichuyenfile(string path1, string path2)
        {
            if (!File.Exists(path1))
                File.Create(path1);
            try
            {
                string nd = "Day la bai tap C#";
                File.WriteAllText(path1, nd);
                if (File.Exists(path2))
                    File.Delete(path2);
                File.Move(path1, path2);
                Console.WriteLine("Done");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Main8(string[] args)
        {
            string tendau = "tendau.txt";
            string tenmoi = "tenmoi.txt";
            dichuyenfile(tendau, tenmoi);
        }

        //9.read the first line of a file.
        static void docdongdautien(string path)
        {
            if (!File.Exists(path))
                Console.WriteLine("File khong ton tai"); return;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string dongdau = sr.ReadLine();
                    if (dongdau != null)
                        Console.WriteLine(dongdau);
                    else Console.WriteLine("File trong");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //if( File.Exists(path))
        //  {
        //    string dongdau = File.Readline(path).FirstOrDefault();
        //    Console.WriteLine(dongdau);
        //  }
        public static void Main9(string[] args)
        {
            string file = "b.txt";
            Console.WriteLine("Dong dau trong file la: ");
            docdongdautien(file);
        }

        //10.tạo và đọc dòng cuối cùng của một tệp.
        static void docdongcuoi(string path)
        {

            string[] mem = new string[] { "Martin", "James", "Juhoon", "Seonghyeon", "Keonho" };
            File.WriteAllLines(path, mem);
            try
            {
                string dongcuoi = null;
                string donghientai;
                using (StreamReader sr = new StreamReader(path))
                {
                    while ((donghientai = sr.ReadLine()) != null)
                    {
                        dongcuoi = donghientai;
                    }
                }
                if (dongcuoi != null)
                    Console.WriteLine(dongcuoi);
                else Console.WriteLine("File trong");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void Main10(string[] args)
        {
            string file = "b.txt";
            Console.WriteLine("Dong cuoi la: ");
            docdongcuoi(file);
        }

        //12.đọc một dòng cụ thể từ một tệp.
        static void docdongcuthe(string path, int n)
        {
            if (!File.Exists(path))
            { Console.WriteLine("File khong ton tai"); return; }
            if (n <= 0) { Console.WriteLine("So dong phai lon hon 0"); return; }
            try
            {
                string dong = null;
                string donghientai;
                int dem = 0;
                using (StreamReader sr = new StreamReader(path))
                {
                    while ((donghientai = sr.ReadLine()) != null)
                    {
                        dem++;
                        if (dem == n)
                        {
                            dong = donghientai;
                            break;
                        }
                    }
                }
                if (dong != null)
                    Console.WriteLine(dong);
                else Console.WriteLine($"File khong co dong thu {n}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void Main12(string[] args)
        {
            string file = "idol.txt";
            Console.Write("Nhap so dong can in: ");
            int so = int.Parse(Console.ReadLine());
            Console.WriteLine("Ket qua: ");
            docdongcuthe(file, so);
        }

        //13.đếm số dòng trong một tệp.
        static void demsodong(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File khong ton tai");
                return;

            }
            try
            {
                int dem = 0;
                string donghientai;
                using (StreamReader sr = new StreamReader(path))
                {

                    while ((donghientai = sr.ReadLine()) != null)
                    {
                        dem++;
                    }
                }
                if (dem != 0)
                {
                    Console.WriteLine(dem);
                }
                else Console.WriteLine("File trong");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // int tongsodong = File.ReadLine(path).Count();
        public static void Main13(string[] args)
        {
            string file = "idol.txt";
            Console.Write("So dong co trong file la: ");
            demsodong(file);
        }

        //14.tạo mảng số 2 chieu random trong file 
        static void taomangso(string path, int[,] arr)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            Random random = new Random();
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine();
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            arr[i, j] = random.Next(0, 100);
                            sw.Write($"{arr[i, j]} ");

                        }
                        sw.WriteLine();

                    }
                    int kq = xuly(arr);
                    sw.Write($"So phan tu chia het cho 2 la: {kq}");

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static int xuly(int[,] arr)
        {
            int dem = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 0)
                        dem++;
                }
            }
            return dem;
        }
        public static void Main14(string[] args)
        {
            string file = "c.txt";
            Console.Write("Nhap so dong: ");
            int dong = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int cot = int.Parse(Console.ReadLine());
            int[,] arr = new int[dong, cot];
            taomangso(file, arr);
            Console.WriteLine("Done");
        }


    }
}

