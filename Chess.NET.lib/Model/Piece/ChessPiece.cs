namespace Chess.NET.Model
{
    public interface ChessPiece
    {
        PieceColor Color { get; set; }
        (int, int)[] GetMoves(int startRow, int startCol);
    }
}
