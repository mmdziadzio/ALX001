using System.Diagnostics;

namespace AlxCousrseHomework.MaterialAssignments
{
    public class Chapter03
    {
        public string Chapter = "Chapter 03";

        public static void Task01()
        {
            double Price;
            Console.WriteLine();
            Console.WriteLine("Ćwiczenie 1");
            Console.WriteLine();
            Console.Write("Podaj wartość zakupów : ");
            Price = Double.Parse(Console.ReadLine());
            if (Price > 100)
            {
                Console.WriteLine($"Dla wskazanej wartość zakópów naliczono rabat w wysokości 15%");
                Console.WriteLine($"Należność do załaty to {Price - (Price * 0.15)}");
            }
            else if (Price > 60)
            {
                Console.WriteLine($"Dla wskazanej wartość zakópów naliczono rabat w wysokości 5%");
                Console.WriteLine($"Należność do załaty to {Price - (Price * 0.05)}");
            }
            else
                Console.WriteLine($"Niestety rabat nie został naliczony");

            Console.WriteLine();
        }

        public static void Task02()
        {
            double Price;
            Console.WriteLine();
            Console.WriteLine("Ćwiczenie 2");
            Console.WriteLine();
            Console.Write("Podaj wartość zakupów : ");
            Price = Double.Parse(Console.ReadLine());
            switch (Price)
            { 
                case > 100:
                    Console.WriteLine($"Dla wskazanej wartość zakópów naliczono rabat w wysokości 15%");
                    Console.WriteLine($"Należność do załaty to {Price - (Price * 0.15)}");
                    break;
                case > 60:
                    Console.WriteLine($"Dla wskazanej wartość zakópów naliczono rabat w wysokości 5%");
                    Console.WriteLine($"Należność do załaty to {Price - (Price * 0.05)}");
                    break;
                default: 
                    Console.WriteLine($"Niestety rabat nie został naliczony");
                    break;
            }
        }

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Rozdział 3");
            Chapter03.Task01();
            Chapter03.Task02();
        }

    }
}
