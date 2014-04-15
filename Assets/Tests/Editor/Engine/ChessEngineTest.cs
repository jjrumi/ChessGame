using System;
using System.Collections;
using System.Collections.Generic;
using BitterBloom.ChessGame.Engine.Pieces;
using Moq;
using NUnit.Framework;

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
			chess = new ChessEngine( boardMock.Object, new Player( Player.PlayerColor.White ), new Player( Player.PlayerColor.Black ), new ConfigChess() );
			chess.Initialize();
			boardMock.Verify( x => x.Initialize() );
		}

		[Test()]
		public void Initialized_Chess_Has_Placed_Pieces_On_The_Board_For_2_Players()
		{
			Mock<IBoard> boardMock = new Mock<IBoard>();
			chess = new ChessEngine( boardMock.Object, new Player( Player.PlayerColor.White ), new Player( Player.PlayerColor.Black ), new ConfigChess() );
			chess.Initialize();
			boardMock.Verify( x => x.PlaceListOfPieces( It.IsAny<Dictionary<Piece, string>>() ), Times.Exactly( 2 ) );
		}

		[Test()]
		public void Initialized_Chess_Has_Linked_Pieces_To_Each_Player()
		{
			Mock<IPlayer> whitePlayerMock = new Mock<IPlayer>();
			Mock<IPlayer> blackPlayerMock = new Mock<IPlayer>();
			chess = new ChessEngine( new Board(), whitePlayerMock.Object, blackPlayerMock.Object, new ConfigChess() );
			chess.Initialize();
			whitePlayerMock.VerifySet( x => x.Pieces = It.IsAny<Dictionary<Piece, string>>() );
			blackPlayerMock.VerifySet( x => x.Pieces = It.IsAny<Dictionary<Piece, string>>() );
		}

		[Test()]
		public void ChessEngine_Publish_List_Of_Board_Tiles()
		{
			Mock<IBoard> boardMock = new Mock<IBoard>();
			chess = new ChessEngine( boardMock.Object, new Player( Player.PlayerColor.White ), new Player( Player.PlayerColor.Black ), new ConfigChess() );
			chess.GetBoardTiles();

			boardMock.Verify( x => x.ListBoardTiles() );
		}

		[Test()]
		public void ChessEngine_Publish_List_Of_Both_Players_Pieces()
		{
			// Arrange:
			Mock<IPlayer> whitePlayerMock = new Mock<IPlayer>();
			Mock<IPlayer> blackPlayerMock = new Mock<IPlayer>();
			chess = new ChessEngine( new Board(), whitePlayerMock.Object, blackPlayerMock.Object, new ConfigChess() );

			ArrayList whitePieces = new ArrayList();
			whitePieces.Add( "White_Piece_A_Info" );
			whitePieces.Add( "White_Piece_B_Info" );
			whitePlayerMock.Setup( x => x.ListPieces() ).Returns( whitePieces );

			ArrayList blackPieces = new ArrayList();
			blackPieces.Add( "Black_Piece_A_Info" );
			blackPieces.Add( "Black_Piece_B_Info" );
			blackPlayerMock.Setup( x => x.ListPieces() ).Returns( blackPieces );

			// Act:
			ArrayList setPieces = chess.GetChessPieces();

			// Assert:
			ArrayList expectedList = new ArrayList( whitePieces );
			expectedList.AddRange( blackPieces );
			Assert.AreEqual( setPieces, expectedList, "Both player pieces are returned" );
		}
	}
}

