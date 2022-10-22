using System;
using MyUtilityLibraries;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cau 1: Chuan hoa ten\n");
            Console.Write("Nhap xau: ");
            string s = Console.ReadLine();
            Console.WriteLine("\nXau da chuan hoa: {0}\n", s.NameStandaldize());

            Console.ReadLine();

        }
    }
}
