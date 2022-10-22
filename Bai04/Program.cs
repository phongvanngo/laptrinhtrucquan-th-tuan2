using System;
using System.Collections.Generic;
using MyUtilityClasses.NAnimal;
namespace Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cau 4:\n ");

            List<Cattle> cattles = new List<Cattle>();
            Console.Write("Number of Cow: ");
            int number_of_Cow = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of Goat: ");
            int number_of_Goat = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of Sheep: ");
            int number_of_Sheep = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number_of_Cow; i++) cattles.Add(new Cow());
            for (int i = 0; i < number_of_Sheep; i++) cattles.Add(new Sheep());
            for (int i = 0; i < number_of_Goat; i++) cattles.Add(new Goat());

            Console.WriteLine("Nhung tieng keu nghe duoc: ");
            int sum_of_milk = 0;
            foreach (Cattle cattle in cattles)
            {
                cattle.ToSound();
                cattle.ToMilk();
                sum_of_milk += cattle.Milk;
            }
            Console.WriteLine("\nAmount of milk "+ sum_of_milk);
        }
    }
}
