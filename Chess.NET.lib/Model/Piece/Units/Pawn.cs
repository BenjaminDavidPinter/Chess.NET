using Chess.NET.Model;

namespace Chess.NET.Units{
    public class Pawn : ChessPiece
    {
        public PieceColor Color {get;set;}

        public BoardSquare[] GetMoves()
        {
            throw new NotImplementedException();
        }

        public void Move(BoardSquare destinationSquare)
        {
            throw new NotImplementedException();
        }
    }
}