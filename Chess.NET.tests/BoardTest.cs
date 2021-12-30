using NUnit.Framework;
using Chess.NET.Model;
using BenchmarkDotNet.Attributes;

namespace Chess.NET.Tests.Board
{
    [TestFixture]
    public class BoardTest
    {

        public ChessBoard? TestBoard { get; set; }

        [GlobalSetup]
        [SetUp]
        public void SetupTests()
        {
            TestBoard = new ChessBoard();
        }

        [Benchmark]
        [Test]
        public void TestBlackPawnSetup()
        {
            for (int i = 0; i < 8; i++)
            {
                Assert.IsTrue(TestBoard.Positions[1, i].Piece.Color == PieceColor.Black);
            }
        }

        [Benchmark]
        [Test]
        public void TestWhitePawnSetup()
        {
            for (int i = 0; i < 8; i++)
            {
                Assert.IsTrue(TestBoard.Positions[6, i].Piece.Color == PieceColor.White);
            }
        }

        [Benchmark]
        public void InitBoard()
        {
            _ = new ChessBoard();
        }
    }
}