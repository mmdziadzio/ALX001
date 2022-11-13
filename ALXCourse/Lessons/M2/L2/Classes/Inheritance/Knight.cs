using ALXCourse.Lessons.M1.L2.Enums;

namespace ALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public class Knight : ChessPieces
    {
        public Knight() : base()
        {
            Type = ChessFiguresType.KNIGHT;
        }
        public override void Move()
        {
            Console.WriteLine("The Knight ins moving ....");
        }
    }
}
