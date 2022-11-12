using ALXCourse.Lessons.M1.L2.Enums;

namespace ALXCourse.Lessons.M1.L2
{
    public class L2EnumAndSwitch
    {
        public static void Run()
        {
            Console.WriteLine("Nowa");
            var whiteQueen = new ChessFigure(ChessFiguresType.QUEEN, ChessColor.WHITE);

            var blackQueen = new ChessFigure();
            blackQueen.FigureType = ChessFiguresType.QUEEN;
            blackQueen.FigureColor = ChessColor.WHITE;

            var whiteKing = new ChessFigure
            {
                FigureType = ChessFiguresType.KING,
                FigureColor = ChessColor.WHITE
            };

            GetFigursType(whiteKing);
            GetFigursType(blackQueen);
            GetFigursType(whiteQueen);
        
        }

        private static void GetFigursType(ChessFigure chessFigure)
        {
            switch (chessFigure.FigureType)
            {
                case ChessFiguresType.QUEEN:
                    Console.WriteLine("The Figure is a Quenn");
                    break;
                case ChessFiguresType.KNIGHT:
                    Console.WriteLine("The Figure is a Knight");
                    break;
                case ChessFiguresType.BISCHOP:
                    Console.WriteLine("The Figure is a Bishop");
                    break;
                case ChessFiguresType.ROOK:
                    Console.WriteLine("The Figure is a Rook");
                    break;
                case ChessFiguresType.PAWN:
                    Console.WriteLine("The Figure is a Pown");
                    break;
                case ChessFiguresType.KING:
                    Console.WriteLine("The Figure is a King");
                    break;             
                default:
                    Console.WriteLine("The type is undefined...");
                    break;
            }
        }
    }
}
