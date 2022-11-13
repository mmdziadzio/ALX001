using ALXCourse.Lessons.M2.L2.Classes;

namespace ALXCourse.Lessons.M2.L2.Interfaces
{
    public interface IInvoiceGenerator
    {
        Invoice GenerateInvoice();

        void SayHallo();
        void SayHallo(string name);
        void TEST();
    }
}
