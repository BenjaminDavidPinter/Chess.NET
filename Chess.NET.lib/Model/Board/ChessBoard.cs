using Chess.NET.Model;
using Chess.NET.Units;

public class ChessBoard
{
    public BoardSquare[,] Positions { get; set; }

    public ChessBoard()
    {
        Positions = new BoardSquare[8, 8];
        InitPawns();
    }

    private void InitPawns()
    {
        for (int i = 0; i < 8; i++)
        {
            var newSquare = new BoardSquare()
            {
                Piece = new Pawn()
                {
                    Color = PieceColor.Black
                }
            };
            Positions[1, i] = newSquare;

            newSquare = new BoardSquare()
            {
                Piece = new Pawn()
                {
                    Color = PieceColor.White
                }
            };
            Positions[6, i] = newSquare;
        }
    }
}