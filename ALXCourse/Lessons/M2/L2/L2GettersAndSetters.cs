using ALXCourse.Lessons.M2.L2.Classes;
using System;

namespace ALXCourse.Lessons.M2.L2
{
    public class L2GettersAndSetters
    {
        public static void Run()
        {
            var computer = new Computer();
            computer.Branda = "PC I";
            computer.Branda = "Dell";
            computer.ProcessorFrequence = 3.66;
            computer.NumberOfCores = 3;
            PresentComputer(computer);
            Console.WriteLine();

            var computer1 = new Computer();
            computer1.Branda = "PC I";
            computer1.Branda = "Apple";
            computer1.ProcessorFrequence = 10;
            computer1.NumberOfCores = 4;
            PresentComputer(computer1);
            Console.WriteLine();
        }

        public static void PresentComputer(Computer computer)
        {
            Console.WriteLine();
            Console.WriteLine($"Computer name: {computer.Name}");
            Console.WriteLine($"Computer Frequence: {computer.ProcessorFrequence}");
            Console.WriteLine($"Computer Brand: {computer.Branda}");
            Console.WriteLine($"Computer Number of Cores: {computer.NumberOfCores}");
            Console.WriteLine();
        }
    }
}
