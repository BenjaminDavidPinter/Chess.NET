using NUnit.Framework;
using Chess.NET.Model;
using Chess.NET.Units;
using BenchmarkDotNet.Attributes;

namespace Chess.NET.Tests.Units
{
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
            Assert.IsTrue(moves.Length == 1);
            Assert.IsTrue(moves[0] == (4, 5));
        }

        [Benchmark]
        [Test]
        public void GetPawnMovesBlack_55()
        {
            Pawn p = new Pawn(){
                Color = PieceColor.Black
            };
            var moves = p.GetMoves(5, 5);

            Assert.IsTrue(moves.Length == 1);
            Assert.IsTrue(moves[0] == (6, 5));
        }

        [Benchmark]
        [Test]
        public void GetPawnMovesBlack_Origin()
        {
            Pawn p = new Pawn(){
                Color = PieceColor.Black
            };
            var moves = p.GetMoves(1,5);

            Assert.IsTrue(moves.Length == 2);
            Assert.IsTrue(moves[0] == (2, 5));
            Assert.IsTrue(moves[1] == (3, 5));
        }

        [Benchmark]
        [Test]
        public void GetPawnMovesWhite_Origin()
        {
            Pawn p = new Pawn(){
                Color = PieceColor.White
            };
            var moves = p.GetMoves(6,5);

            Assert.IsTrue(moves.Length == 2);
            Assert.IsTrue(moves[0] == (5, 5));
            Assert.IsTrue(moves[1] == (4, 5));
        }
    }
}