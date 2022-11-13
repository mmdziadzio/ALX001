using ALXCourse.Lessons.M1.L2.Enums;

namespace ALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public abstract class ChessPieces
    {
        public ChessColor? Color { get; set; }      
        public ChessFiguresType? Type { get; set; }
        public int Xposition { get; set; }
        public int Yposition { get; set; }
        public bool IsAlive { get; set; }   

        public ChessPieces()
        {
            IsAlive = true;
        }

        public virtual void Move()
        {
            Console.WriteLine("Ches Piece is moving... ****");
            Console.WriteLine();
        }
        public void Present()
        {
            Console.WriteLine();
            Console.WriteLine(".....................................................");
            Console.WriteLine($"TChess {Type}");
            Console.WriteLine($"Color {Color}");  // base niewymagane
            Console.WriteLine($"Is it Alive {IsAlive}");
            Console.WriteLine($"X position {Xposition}");
            Console.WriteLine($"Y position {Yposition}");
            Console.WriteLine();
            Console.WriteLine(".....................................................");
            
        }
    }
}
