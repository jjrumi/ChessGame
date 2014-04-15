using System;
using System.Collections;
using System.Collections.Generic;
using BitterBloom.ChessGame.Engine.Pieces;
using Moq;
using NUnit.Framework;

namespace BitterBloom.ChessGame.Engine.Tests
{
	[TestFixture()]
	public class BoardTest
	{
		private Board board;
		private ConfigChess config;
		string[] hCoord;
		string[] vCoord;

		[SetUp]
		public void Init()
		{
			board = new Board();
			config = new ConfigChess();
			hCoord = config.ListHorizontalBoardCoordinates();
			vCoord = config.ListVerticalBoardCoordinates();
			board.Initialize( hCoord, vCoord );
		}

		[Test()]
		public void Initialized_Board_Has_A_List_Of_Tiles()
		{
			Assert.IsNotEmpty( board.Tiles, "Initialized board has a collection of tiles" );
		}

		[Test()]
		public void Initialized_Board_Has_A_Configured_List_Of_Empty_Tiles()
		{
			string firstCoord = hCoord[0] + vCoord[0];
			string lastCoord = hCoord[hCoord.Length - 1] + vCoord[vCoord.Length - 1];

			Assert.IsTrue( board.IsTileEmpty( firstCoord ), "Board has first coordinate empty" );
			Assert.IsTrue( board.IsTileEmpty( lastCoord ), "Board has last coordinate empty" );
		}

		[Test()]
		public void Can_Place_Piece_On_An_Empty_Tile()
		{
			board.PlacePiece( ( new Mock<Piece>() ).Object, "A2" );
			Assert.IsFalse( board.Tiles["A2"].IsEmpty(), "Piece placed on non empty tile" );
		}

		[Test()]
		[ExpectedException( typeof( Board.TargetTileOccupiedException ) )]
		public void Cannot_Place_Piece_On_An_Occupied_Tile()
		{
			board.PlacePiece( ( new Mock<Piece>() ).Object, "A2" );
			board.PlacePiece( ( new Mock<Piece>() ).Object, "A2" );
		}

		[Test()]
		public void Can_Place_A_Collection_Of_Pieces()
		{
			// Create collection of 2 [Piece => coord].
			Dictionary<Piece, string> collection = new Dictionary<Piece, string>();
			collection.Add( ( new Mock<Piece>() ).Object, "A1" );
			collection.Add( ( new Mock<Piece>() ).Object, "B1" );

			// Define 2 tiles for the board.
			Mock<ITile> tileA1Mock = new Mock<ITile>();
			Mock<ITile> tileB1Mock = new Mock<ITile>();
			tileA1Mock.Setup( x => x.IsEmpty() ).Returns( true );
			tileB1Mock.Setup( x => x.IsEmpty() ).Returns( true );

			Dictionary<string, ITile> tiles = new Dictionary<string, ITile>();
			tiles.Add( "A1", tileA1Mock.Object );
			tiles.Add( "B1", tileB1Mock.Object );
			board.Tiles = tiles;

			// Place the 2 pieces in the two mocked tiles.
			board.PlaceCollectionOfPieces( collection );

			tileA1Mock.Verify( x => x.PlacePiece( It.IsAny<Piece>() ), Times.Once() );
			tileB1Mock.Verify( x => x.PlacePiece( It.IsAny<Piece>() ), Times.Once() );
		}

		[Test()]
		public void Board_Publish_List_Of_Tile_Names()
		{
			string firstCoord = hCoord[0] + vCoord[0];
			string lastCoord = hCoord[hCoord.Length - 1] + vCoord[vCoord.Length - 1];

			ArrayList list = board.ListBoardTiles();
			Assert.That( list.Contains( firstCoord ) );
			Assert.That( list.Contains( lastCoord ) );
		}
	}
}
