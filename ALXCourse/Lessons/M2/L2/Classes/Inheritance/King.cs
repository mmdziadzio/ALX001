using ALXCourse.Lessons.M1.L2.Enums;

namespace ALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public class King : ChessPieces 
    {
        public bool Chesked { get; set; }

        public King() : base()
        {
            Chesked = false;
            Type = ChessFiguresType.KING;
        }

        public override void Move()
        {
            Console.WriteLine("The King ins moving ....");
        }
    }
}
