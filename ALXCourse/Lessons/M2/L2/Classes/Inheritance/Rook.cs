using ALXCourse.Lessons.M1.L2.Enums;

namespace ALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public class Rook : ChessPieces
    {
        public Rook()
        {
            Type = ChessFiguresType.ROOK;
        }
        public override void Move()
        {
            Console.WriteLine("The Rook ins moving ....");
        }
    }
}
