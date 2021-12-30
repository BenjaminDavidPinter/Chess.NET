namespace Chess.NET.Model
{

    public class BoardSquare
    {
        public BoardSquare(int row, int col){
            Row = row;
            Col = col;
        }
        public ChessPiece? Piece { get; set; }
        public int Row {get;set;}
        public int Col {get;set;}
    }
}
