using ALXCourse.Lessons.M2.L2.Classes.Inheritance;
using System.Net.NetworkInformation;

namespace ALXCourse.Lessons.M2.L2
{
    public class L2Inheritance
    {
        public static void Run()
        {
            // ChessPieces chessPieces = new ChessPieces(); zabezpiecznie przez abstract

            Queen queen = new Queen();
            queen.Move();
            queen.Xposition = 2;
            queen.Yposition = 2;
            queen.Present();
            ConfirmLiveness(queen);

            Knight knight = new Knight();
            knight.Move();
            knight.Xposition = 2;
            knight.Yposition = 2;
            knight.Present();
            ConfirmLiveness(knight);

            King king = new King();
            king.Move();
            king.Xposition = 2;
            king.Yposition = 2;
            king.Present();
            ConfirmLiveness(king);

            Rook rook = new Rook();
            rook.Move();
            rook.Xposition = 2;
            rook.Yposition = 2;
            rook.Present();
            ConfirmLiveness(rook);

            ChessPieces pown = new Pown();
            pown.Move();
            pown.Xposition = 2;
            pown.Yposition = 2;
            pown.Present();
            ConfirmLiveness(pown);
        }

        public static void ConfirmLiveness(ChessPieces pieces)
        {
            if (pieces.IsAlive)
            
                Console.WriteLine("The Piecse is alive");
            else
                Console.WriteLine("The Piecse is dead");
        }
    }
}
