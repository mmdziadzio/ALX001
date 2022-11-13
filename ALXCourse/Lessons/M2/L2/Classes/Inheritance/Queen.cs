using ALXCourse.Lessons.M1.L2.Enums;

namespace ALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public class Queen : ChessPieces
    {
        public Queen()
        {
            Type = ChessFiguresType.QUEEN;
        }
        public override void Move()
        {
            Console.WriteLine("The Queen ins moving ....");
        }

        public void Present()
        {
            Console.WriteLine("The Queen");
            Console.WriteLine($"Color {base.Color}");  // base niewymagane
            Console.WriteLine($"X position {base.Xposition}");
            Console.WriteLine($"Y position {base.Yposition}");
        }
    }
}
