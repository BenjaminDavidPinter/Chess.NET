using Chess.NET.Model;
using Chess.NET.Units;

public class ChessBoard
{
    public BoardSquare[,] Positions { get; set; }

    public ChessBoard()
    {
        Positions = new BoardSquare[8, 8];
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Positions[i, j] = new BoardSquare(i, j);
            }
        }
        InitPawns();
    }

    private void InitPawns()
    {
        for (int i = 0; i < 8; i++)
        {
            Positions[1, i].Piece = new Pawn()
            {
                Color = PieceColor.Black
            };

            Positions[6, i].Piece = new Pawn()
            {
                Color = PieceColor.White
            };
        }
    }
}