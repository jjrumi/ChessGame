using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using BitterBloom.ChessGame.Engine.Pieces;

namespace BitterBloom.ChessGame.Engine.Tests
{
	[TestFixture()]
	public class ChessEngineTest
	{
		private ChessEngine chess;

		[Test()]
		public void Initialized_Chess_Has_A_Board_Initialized()
		{
			var boardMock = new Mock<IBoard>();
			chess = new ChessEngine( boardMock.Object, new Player( ChessEngine.PlayerColor.White ), new Player( ChessEngine.PlayerColor.Black ) );
			chess.Initialize();
			boardMock.Verify( x => x.Initialize() );
		}

		[Test()]
		public void Initialized_Chess_Has_Placed_Pieces_On_The_Board_For_2_Players()
		{
			Mock<IBoard> boardMock = new Mock<IBoard>();
			chess = new ChessEngine( boardMock.Object, new Player( ChessEngine.PlayerColor.White ), new Player( ChessEngine.PlayerColor.Black ) );
			chess.Initialize();
			boardMock.Verify( x => x.PlaceListOfPieces( It.IsAny<Dictionary<Piece, string>>() ), Times.Exactly(2));
		}

		[Test()]
		public void Initialized_Chess_Has_Linked_Pieces_To_Each_Player()
		{
			Mock<IPlayer> whitePlayerMock = new Mock<IPlayer>();
			Mock<IPlayer> blackPlayerMock = new Mock<IPlayer>();
			chess = new ChessEngine( new Board(), whitePlayerMock.Object, blackPlayerMock.Object );
			chess.Initialize();
			whitePlayerMock.VerifySet( x => x.Pieces=It.IsAny<Dictionary<Piece, string>>() );
			blackPlayerMock.VerifySet( x => x.Pieces=It.IsAny<Dictionary<Piece, string>>() );
		}

		// TODO: Test retrieve board tiles and publish ArrayList.
		// TODO: Test retrieve chess pieces from each player and publish ArrayList.
	}
}

