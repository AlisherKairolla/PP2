using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter New = new StreamWriter(@"D:\kbtu\principes of programing\c#\txt_files\5.txt");
            New.Write(3333);
            New.Close();

            File.Copy(@"D:\kbtu\principes of programing\c#\txt_files\5.txt", @"D:\kbtu\principes of programing\c#\4.txt");
            File.Delete(@"D:\kbtu\principes of programing\c#\txt_files\5.txt");
        }
    }
}
