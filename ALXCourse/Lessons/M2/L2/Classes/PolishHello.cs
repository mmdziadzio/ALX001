using ALXCourse.Lessons.M2.L2.Interfaces;

namespace ALXCourse.Lessons.M2.L2.Classes
{
    internal class PolishHello : IInvoiceGenerator
    {
        public Invoice GenerateInvoice()
        {
            throw new NotImplementedException();
        }

        public void SayHallo()
        {
            Console.WriteLine("Cześć World");
        }

        public void SayHallo(string name)
        {
            Console.WriteLine($"Cześć {name}!");
        }

        public void TEST()
        {
            throw new NotImplementedException();
        }
    }
}
