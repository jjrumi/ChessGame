using NUnit.Framework;
using System;

namespace BitterBloom.ChessGame.Engine.Tests
{
	[TestFixture()]
	public class ChessEngineTest
	{
		private ChessEngine chess;

		[SetUp]
		public void Init()
		{
			chess = new ChessEngine();
			chess.Initialize();
		}

		[Test()]
		public void Initialized_Chess_Has_White_Pieces_Placed()
		{
			Assert.AreEqual( ChessEngine.PieceID.King, chess.getBoardTiles()["E1"].Piece.PieceID, "Starting position for WhiteKing is E1" );
		}

		[Test()]
		public void Initialized_Chess_Has_Black_Pieces_Placed()
		{
			Assert.AreEqual( ChessEngine.PieceID.King, chess.getBoardTiles()["E8"].Piece.PieceID, "Starting position for BlackKing is E(" );
		}
	}
}

