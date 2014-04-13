using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BitterBloom.ChessGame.Engine.Tests
{
	[TestFixture()]
	public class BoardTest
	{
		private Board board;

		[SetUp]
		public void Init()
		{
			board = new Board();
			board.Initialize();
		}

		[Test()]
		public void Initialized_Board_Has_All_Necessary_Tiles()
		{
			Assert.AreEqual( 64, board.Tiles.Count, "Board has 64 tiles" );
		}

		[Test()]
		public void Can_Place_Piece_On_An_Empty_Tile_Of_The_Board()
		{
			board.PlacePiece( new Pawn( ChessEngine.PieceID.PawnA ), "A2" );
			Assert.IsFalse( board.Tiles["A2"].IsEmpty(), "Piece placed and board tile not empty" );
		}

		[Test()]
		[ExpectedException( typeof( Board.TargetTileOccupiedException ) )]
		public void Cannot_Place_Piece_On_An_Occupied_Tile_Of_The_Board()
		{
			board.PlacePiece( new Pawn( ChessEngine.PieceID.PawnA ), "A2" );
			board.PlacePiece( new Rook( ChessEngine.PieceID.QueensRook ), "A2" );
		}
	}
}
