
using System;
using System.Diagnostics;

namespace ALXCourse.Lessons.L2
{
    public class L2Conditionalscs
    {
        public static void Run()
        {
            Console.Write("\n");
            Console.Write("Enter a number: ");
            var number = Int32.Parse(Console.ReadLine());
            CheckIfNumberIsEven(number);
            Console.Write("\n");          

            Console.Write("Enter a limit1: ");
            var limit1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a limit2: ");
            var limit2 = Int32.Parse(Console.ReadLine());

            CheckWhereIsNumber(number);
            Console.Write("\n");
            CheckNumberWithInLimits(number,limit1,limit2);
        }

        private static void CheckIfNumberIsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.Write($"Liczba {number} jest parzysta");
            }
            else
            {
                Console.Write($"Liczba {number} jest nieparzysta");
            }

        }

        private static void CheckWhereIsNumber(int number)
        {
            if (number < 0)
            {
                Console.Write($"Liczba {number} jest mniejsza od zera / number is smaller then 0");
            }
            else if (number == 0)
            {
                Console.Write($"Liczba {number} jest równa zero");
            }
            else if (number > 0 && number < 5)
            {
                Console.Write($"Liczba {number} pomiędzy 0 a 5");
            }
            else if (number == 5)
            {
                Console.Write($"Liczba {number} równa 5");
            }
            else
            {
                Console.Write($"Liczba {number} więkasza od 5");
            }
        }
        private static void CheckNumberWithInLimits(int number, int limit1, int limit2)
        {
            if (number < limit1)
            {
                Console.Write($"Liczba {number} jest mniejsza od {limit1}");
            }
            else if (number > limit2)
            {
                Console.Write($"Liczba {number} Większa niz {limit2}");
            }     
            else
            {
                Console.Write($"Liczba {number} the byumber is equal to {limit1} or equal {limit2} \nor between {limit1} and {limit2}");
            }
        }
    }
}
