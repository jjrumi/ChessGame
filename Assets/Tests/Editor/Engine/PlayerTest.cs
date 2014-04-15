using System;
using System.Collections;
using System.Collections.Generic;
using BitterBloom.ChessGame.Engine.Pieces;
using Moq;
using NUnit.Framework;

namespace BitterBloom.ChessGame.Engine.Tests
{
	[TestFixture()]
	public class PlayerTest
	{
		private Player player;

		[Test()]
		public void Player_Publish_List_Of_His_Pieces()
		{
			Dictionary<Piece, string> pieces = new Dictionary<Piece, string>();
			pieces.Add( ( new Mock<Piece>() ).Object, "A1" );
			pieces.Add( ( new Mock<Piece>() ).Object, "B1" );
			pieces.Add( ( new Mock<Piece>() ).Object, "C1" );

			player = new Player( Player.PlayerColor.Black );
			player.Pieces = pieces;
			ArrayList publicList = player.ListPieces();

			Assert.AreEqual( pieces.Count, publicList.Count, "List of pieces is published" );
		}
	}
}

