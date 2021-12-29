using NUnit.Framework;
using Chess.NET.Model;

[TestFixture]
public class BoardTest{
  
  public ChessBoard TestBoard {get;set;}

  [SetUp]
  public void SetupTests(){
    TestBoard = new ChessBoard();
  }

  [Test]
  public void TestBlackPawnSetup(){
    for(int i = 0; i < 9; i++){
    Assert.IsTrue(TestBoard.Positions[0,i].Piece.Color == PieceColor.Black);
    }
  }
}
