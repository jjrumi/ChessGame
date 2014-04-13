/*
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BitterBloom.ChessGame.Engine.Tests
{
	[TestFixture()]
	public class BoardTest
	{
		[Test()]
		public void Initialized_Board_Has_All_Necessary_Tiles()
		{
			Board board = new Board();
			board.Initialize();

			List<Tile> tiles = board.getTiles();
			Tile firstTile = ( tiles[0] as Tile );
			Tile lastTile = ( tiles[tiles.Count - 1] as Tile );

			Assert.AreEqual( 64, tiles.Count, "Board has 64 tiles" );
			Assert.AreEqual( "A1", firstTile.name, "First tile is A1" );
			Assert.IsTrue( 0 == firstTile.hPosition && 0 == firstTile.vPosition, "First tile is located at [0,0]" );
			Assert.AreEqual( "H8", lastTile.name, "Last tile is H8" );
			Assert.IsTrue( 7 == lastTile.hPosition && 7 == lastTile.vPosition, "First tile is located at [7,7]" );
		}
	}
}
*/