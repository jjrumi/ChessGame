using System;
using BitterBloom.ChessGame.Engine.Pieces;
using Moq;
using NUnit.Framework;

namespace BitterBloom.ChessGame.Engine.Tests
{
	[TestFixture()]
	public class TileTest
	{
		[Test()]
		public void New_Tiles_Are_Empty()
		{
			Tile tile = new Tile( "ID" );
			Assert.That( tile.IsEmpty(), "Newly created tiles are empty" );
		}

		[Test()]
		public void Tile_No_Longer_Empty_After_Placing_A_Piece()
		{
			Tile tile = new Tile( "ID" );
			tile.PlacePiece( ( new Mock<Piece>() ).Object );
			Assert.That( !tile.IsEmpty(), "Tile not empty after placing a piece" );
		}
	}
}

