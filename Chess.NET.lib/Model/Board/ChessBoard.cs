namespace Chess.NET.Model{
public class ChessBoard {
   public BoardSquare[,] Positions {get;set;}

   public ChessBoard(){
       Positions = new BoardSquare[8,8];
   }

   private static void AssignPawns(){
        
   }
}
}
