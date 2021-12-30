using NUnit.Framework;
using Chess.NET.Model;
using Chess.NET.Units;
using BenchmarkDotNet.Attributes;

namespace Chess.NET.Tests.Units
{
    [SimpleJob(3, 10, 10)]
    [TestFixture]
    public class PawnTests
    {
        [Benchmark]
        [Test]
        public void GetPawnMovesWhite_55()
        {
            Pawn p = new Pawn(){
                Color = PieceColor.White
            };
            var moves = p.GetMoves(5, 5);
            Assert.IsTrue(moves.Length == 3);
            Assert.IsTrue(moves[0] == (4, 5));
            Assert.IsTrue(moves[1] == (4, 6));
            Assert.IsTrue(moves[2] == (4, 4));
        }

        [Benchmark]
        [Test]
        public void GetPawnMovesBlack_55()
        {
            Pawn p = new Pawn(){
                Color = PieceColor.Black
            };
            var moves = p.GetMoves(5, 5);

            Assert.IsTrue(moves.Length == 3);
            Assert.IsTrue(moves[0] == (6, 5));
            Assert.IsTrue(moves[1] == (6, 6));
            Assert.IsTrue(moves[2] == (6, 4));
        }

        [Benchmark]
        [Test]
        public void GetPawnMovesBlack_Origin()
        {
            Pawn p = new Pawn(){
                Color = PieceColor.Black
            };
            var moves = p.GetMoves(1,5);

            Assert.IsTrue(moves.Length == 4);
            Assert.IsTrue(moves[0] == (2, 5));
            Assert.IsTrue(moves[1] == (3, 5));
            Assert.IsTrue(moves[2] == (2, 6));
            Assert.IsTrue(moves[3] == (2, 4));
        }

        [Benchmark]
        [Test]
        public void GetPawnMovesWhite_Origin()
        {
            Pawn p = new Pawn(){
                Color = PieceColor.White
            };
            var moves = p.GetMoves(6,5);

            Assert.IsTrue(moves.Length == 4);
            Assert.IsTrue(moves[0] == (5, 5));
            Assert.IsTrue(moves[1] == (4, 5));
            Assert.IsTrue(moves[2] == (5, 6));
            Assert.IsTrue(moves[3] == (5, 4));
        }
        
        [Benchmark]
        [Test]
        public void GetPawnMovesWhite_AtEndOfBoard()
        {
            Pawn p = new Pawn(){
                Color = PieceColor.White
            };
            var moves = p.GetMoves(0, 5);
            Assert.IsTrue(moves.Length == 0);
        }

        [Benchmark]
        [Test]
        public void GetPawnMovesBlack_AtEndOfBoard()
        {
            Pawn p = new Pawn(){
                Color = PieceColor.Black
            };
            var moves = p.GetMoves(7, 5);
            Assert.IsTrue(moves.Length == 0);
        }

        [Benchmark]
        [Test]
        public void GetPawnMovesBlack_AtLeftEdgeOfBoard(){
            Pawn p = new Pawn(){
                Color = PieceColor.Black
            };
            var moves = p.GetMoves(1,0);

            Assert.IsTrue(moves.Length == 3);
            Assert.IsTrue(moves[0] == (2, 0));
            Assert.IsTrue(moves[1] == (3, 0));
            Assert.IsTrue(moves[2] == (2, 1));
        }

        [Benchmark]
        [Test]
        public void GetPawnMovesWhite_AtLeftEdgeOfBoard(){
            Pawn p = new Pawn(){
                Color = PieceColor.White
            };
            var moves = p.GetMoves(6,0);

            Assert.IsTrue(moves.Length == 3);
            Assert.IsTrue(moves[0] == (5, 0));
            Assert.IsTrue(moves[1] == (4, 0));
            Assert.IsTrue(moves[2] == (5, 1));
        }

        [Benchmark]
        [Test]
        public void GetPawnMovesBlack_AtRightEdgeOfBoard_Origin(){
            Pawn p = new Pawn(){
                Color = PieceColor.Black
            };
            var moves = p.GetMoves(1,7);

            Assert.IsTrue(moves.Length == 3);
            Assert.IsTrue(moves[0] == (2, 7));
            Assert.IsTrue(moves[1] == (3, 7));
            Assert.IsTrue(moves[2] == (2, 6));
        }

        [Benchmark]
        [Test]
        public void GetPawnMovesWhite_AtRightEdgeOfBoard_Origin(){
            Pawn p = new Pawn(){
                Color = PieceColor.White
            };
            var moves = p.GetMoves(6,7);

            Assert.IsTrue(moves.Length == 3);
            Assert.IsTrue(moves[0] == (5, 7));
            Assert.IsTrue(moves[1] == (4, 7));
            Assert.IsTrue(moves[2] == (5, 6));
        }

        [Benchmark]
        [Test]
        public void GetPawnMovesBlack_AtRightEdgeOfBoard_Rank4(){
            Pawn p = new Pawn(){
                Color = PieceColor.Black
            };
            var moves = p.GetMoves(4,7);

            Assert.IsTrue(moves.Length == 2);
            Assert.IsTrue(moves[0] == (5, 7));
            Assert.IsTrue(moves[1] == (5, 6));
        }

        [Benchmark]
        [Test]
        public void GetPawnMovesWhite_AtRightEdgeOfBoard_Rank4(){
            Pawn p = new Pawn(){
                Color = PieceColor.White
            };
            var moves = p.GetMoves(4,7);

            Assert.IsTrue(moves.Length == 2);
            Assert.IsTrue(moves[0] == (3, 7));
            Assert.IsTrue(moves[1] == (3, 6));
        }
    }
}