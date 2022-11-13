using ALXCourse.Lessons.M2.L2.Interfaces;

namespace ALXCourse.Lessons.M2.L2.Classes
{
    public class InvoiceGenerator : IInvoiceGenerator
    {
        public Invoice GenerateInvoice()
        {
            throw new NotImplementedException();
        }

        public void SayHallo()
        {
            Console.WriteLine("Hallo World");
        }

        public void SayHallo(string name)
        {
            Console.WriteLine($"Hallo {name}!");
        }

        public void TEST()
        {
            throw new NotImplementedException();
        }
    }
}
