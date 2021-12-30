using Chess.NET.Model;

namespace Chess.NET.Units
{
    public class Pawn : ChessPiece
    {
        public PieceColor Color { get; set; }

        public (int, int)[] GetMoves(int startRow, int startCol)
        {
            /*
            Pawns can move only along a column, so we only have to worry about two rules;
                When a pawn is in start position, it can move UP TO two spaces
                En Passant
            */
            if (Color == PieceColor.White)
            {
                if (startRow == 6)
                {
                    return new (int, int)[] { (startRow - 1, startCol), (startRow - 2, startCol) };
                }
                else {
                    if(startRow != 0){
                        return new (int, int)[] { (startRow - 1, startCol) };
                    }
                    else {
                        return new (int, int)[0];
                    }
                }
            }
            else if (Color == PieceColor.Black)
            {
                if (startRow == 1)
                {
                    return new (int, int)[] { (startRow + 1, startCol), (startRow + 2, startCol) };
                }
                else {
                    if(startRow != 7){
                    return new (int, int)[] { (startRow + 1, startCol) };
                    }
                    else {
                        return new (int, int)[0];
                    }
                }
            }
            throw new Exception("Invalid move state achieved, cannot provide moves for pawn state");
        }
    }
}