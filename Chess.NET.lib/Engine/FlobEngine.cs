using Chess.NET.Model;

namespace Chess.NET.Engine{
    public static class FlobEngine{
        public static ChessBoard MakeMove(ChessBoard board, PieceColor forColor){
            var availableMoves = GetMoves(board, forColor);

            return board;
        }

        private static List<((int,int)[], Type)> GetMoves(ChessBoard board, PieceColor forColor) {
            List<((int,int)[], Type)> moves = new List<((int,int)[], Type)>(16);
            for(int i = 0; i < 8; i++){
                for(int j = 0; j < 8; j++){
                    if (board.Positions[i,j].Piece != null
                    && board.Positions[i,j].Piece.Color == forColor){
                        moves.Add((board.Positions[i,j].Piece.GetMoves(i,j), board.Positions[i,j].Piece.GetType()));
                    }
                }
            }
            return moves;
        }
    }
}