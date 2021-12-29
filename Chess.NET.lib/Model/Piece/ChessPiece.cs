namespace Chess.NET.Model{
  public interface ChessPiece {
    PieceColor Color { get; set; }
    BoardSquare[] GetMoves();
    void Move(BoardSquare destinationSquare);
}
}
