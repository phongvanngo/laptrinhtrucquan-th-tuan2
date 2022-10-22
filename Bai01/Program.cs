using System;
using System.IO;
using MyUtilityLibraries;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap duong dan: ");
            string fileDir = Console.ReadLine();
            if (Directory.Exists(fileDir))
            {
                string[] myDic = Directory.GetDirectories(fileDir);
                string[] myFiles = Directory.GetFiles(fileDir);
                foreach (string item in myDic)
                {
                    DirectoryInfo a = new DirectoryInfo(item);
                    Console.WriteLine(a.Name);
                }
                foreach (string item in myFiles)
                {
                    FileInfo file = new FileInfo(item);
                    Console.WriteLine(file.Name);
                }
            }
            else
            {
                Console.WriteLine("Duong dan khong ton tai");
            }

        }
    }
}
