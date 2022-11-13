using ALXCourse.Lessons.M1.L2.Enums;

namespace ALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    internal class Bishop : ChessPieces
    {
        public Bishop() : base()
        {
            Type = ChessFiguresType.BISCHOP;
        }
        public override void Move()
        {
            Console.WriteLine("The Bishop ins moving ....");
        }
    }
}
