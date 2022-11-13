using ALXCourse.Lessons.M1.L2.Enums;

namespace ALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public class Pown : ChessPieces
    {
        public Pown() : base()
        {
            Type = ChessFiguresType.PAWN;
        }
        public override void Move()
        {
            Console.WriteLine("The Pown ins moving ....");
        }
    }
}
