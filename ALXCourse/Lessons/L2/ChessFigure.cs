
using ALXCourse.Lessons.L2.Enums;

namespace ALXCourse.Lessons.L2
{
    public class ChessFigure
    {
        public ChessFiguresType FigureType;
        public ChessColor FigureColor;

        public ChessFigure() { }

        public ChessFigure(ChessFiguresType chesFigureType, ChessColor chessColors)
        {
            FigureType = chesFigureType;    
            FigureColor = chessColors;
        }

    }
}
