using System;
using MyUtilityClasses.NShape;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cau 3\n");
            Reactangle rec = new Reactangle();
            rec.Input();
            Console.WriteLine("\nDien tich: " + rec.CalculateArea());
            Console.WriteLine("Chu vi: " + rec.CalculatePerimeter());
        }
    }
}
