using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Example2
{
    // DirectoryInfo
    // FileInfo
    // Directory, File, Path
    // FileStream, StreamReader, StreamWriter
    class Program
    {
        public static void Ex1()
        {
            DirectoryInfo directory = new DirectoryInfo(@"c:\windows");
            Console.WriteLine(directory.Name);
            Console.WriteLine(directory.FullName);
            Console.ReadKey();
        }
        public static void Ex2()
        {
            DirectoryInfo directory = new DirectoryInfo(@"c:\windows");
            FileInfo[] files = directory.GetFiles();

            Console.WriteLine("Files:" + files.Length);
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
            Console.WriteLine();

            DirectoryInfo[] directories = directory.GetDirectories();
            Console.WriteLine("Directories:" + directories.Length);
            foreach (DirectoryInfo dInfo in directories)
            {
                Console.WriteLine(dInfo.Name);
            }
            Console.ReadKey();
        }

        public static void emptySpaces(int p) 
        {
            for (int i = 0; i < p * 2; i++)
                Console.Write("-");
        }
        public static void Ex3(string path, int level)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                emptySpaces(level);
                Console.WriteLine("Files:" + directory.GetFiles().Length);
                foreach (FileInfo file in directory.GetFiles())
                {
                    emptySpaces(level);
                    Console.WriteLine(file.FullName);
                }

                emptySpaces(level);
                Console.WriteLine("Directories:" + directory.GetDirectories().Length);
                foreach (DirectoryInfo dInfo in directory.GetDirectories())
                {
                    emptySpaces(level);
                    Console.WriteLine(dInfo.FullName);
                    Ex3(dInfo.FullName, level + 1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
        }
        public static void Ex4()
        {
            StreamWriter sw = new StreamWriter(@"c:\work\a.txt");
            sw.WriteLine("hello world");
            sw.Close();
        }
        public static void Ex5()
        {
            StreamReader sr = new StreamReader(@"c:\work\a.txt");
            string[] arr = sr.ReadLine().Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(a + b);
            Console.ReadKey();
        }
        public static void Ex6()
        {
            StreamReader sr = new StreamReader(@"c:\work\input.txt");
            StreamWriter sw = new StreamWriter(@"c:\work\output.txt");
            string[] arr = sr.ReadLine().Split();
            foreach (string s in arr)
            {
                string[] p = s.Split(',');
                sw.WriteLine(p[0] + " - " + p[1]);
            }
            sw.Close();
            sr.Close();
        }
        static void Main(string[] args)
        {
            Ex5();
        }
    }
}
