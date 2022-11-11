using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCousrseHomework.MaterialAssignments
{
    internal class Chapter02
    {
        public string Chapter = "Chapter 02";

        public static void Task01()
        {
            int a = 3;
            int b = 6;
            int c = 15;
            double Res;

            Res =((a^b)/2)%c;
            
            Console.WriteLine();
            Console.WriteLine("Ćwiczenie 1");
            Console.WriteLine($"((a^b)/2)%c={Res}");
            Console.WriteLine();
        }

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Rozdział 2");
            Chapter02.Task01();
        }
    }
}
