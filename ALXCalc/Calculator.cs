using System.Net;

namespace ALXCalculator
{
    public class Calculator
    {
        public void Run()
        {

            // Console.WriteLine($"{x} + {y} = {Add(x, y)}");
            // Console.WriteLine($"{x} - {y} = {Substract(x, y)}");
            // Console.WriteLine($"{x} * {y} = {Multiply(x, y)}");
            // Console.WriteLine($"{x} / {y} = {Divide(x, y)}");

            char operationChar;
            Console.WriteLine("Operation: ...");
            Console.WriteLine("+      Addittion: ...");
            Console.WriteLine("-      Substraction: ...");
            Console.WriteLine("*      Multiplication: ...");
            Console.WriteLine("/      Division: ...");
            Console.WriteLine();
            Console.WriteLine("Or pres N to end application");
            do
            {
                Console.WriteLine("Choose Operation: ...");
                operationChar = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine("Running calculator...");
                Console.Write("X number: ");
                var x = Double.Parse(Console.ReadLine());
                Console.Write("Y number: ");
                var y = Double.Parse(Console.ReadLine());
                PerformOperation(operationChar, x, y);
            } while (operationChar != 'N');
        }
        private void PerformOperation(char operationChar, double x, double y)
        {
            switch (operationChar)
            {
                case '+':
                    Console.WriteLine($"{x} + {y} = {Add(x, y)}");
                    break;
                case '-':
                    Console.WriteLine($"{x} - {y} = {Substract(x, y)}");
                    break;
                case '*':
                    Console.WriteLine($"{x} * {y} = {Multiply(x, y)}");
                    break;
                case '/':
                    Console.WriteLine($"{x} / {y} = {Divide(x, y)}");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }

        private double Add(double x, double y)
        {
            return x + y;
        }

        private double Substract(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }
    }
}