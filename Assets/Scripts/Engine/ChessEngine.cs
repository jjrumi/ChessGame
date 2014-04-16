using System;
using System.Collections;
using System.Collections.Generic;
using BitterBloom.ChessGame.Engine.Pieces;

namespace BitterBloom.ChessGame.Engine
{
	public class ChessEngine : IChessEngine
	{
		private IBoard board;
		private IPlayer white;
		private IPlayer black;
		private ConfigChess config;

		public ChessEngine( IBoard board, IPlayer white, IPlayer black, ConfigChess config )
		{
			this.board = board;
			this.white = white;
			this.black = black;
			this.config = config;
		}

		/**
		 * Setup board, pieces and links them to board and players.
		 */
		public void Initialize()
		{
			board.Initialize( config.ListHorizontalBoardCoordinates(), config.ListVerticalBoardCoordinates() );
			Dictionary<Piece, string> whitePieces = config.ListClassicLocationForWhitePieces();
			Dictionary<Piece, string> blackPieces = config.ListClassicLocationForBlackPieces();
			board.PlaceCollectionOfPieces( whitePieces );
			board.PlaceCollectionOfPieces( blackPieces );
			white.Pieces = whitePieces;
			black.Pieces = blackPieces;
		}

		public ArrayList GetBoardTiles()
		{
			return board.ListBoardTiles();
		}

		public ArrayList GetChessPieces()
		{
			ArrayList whitePieces = white.ListPieces();
			ArrayList blackPieces = black.ListPieces();
			ArrayList mergedList = new ArrayList();
			mergedList.AddRange( whitePieces );
			mergedList.AddRange( blackPieces );

			return mergedList;
		}

		/**
		 * TODO: Implement.
		 */
		public ArrayList GetAllowedMoves( string coord )
		{
			ArrayList moves = new ArrayList();
			moves.Add( "A3" );
			moves.Add( "A4" );

			return moves;
		}

		/**
		 * TODO: Implement.
		 */
		public bool MovePiece( string[] coords )
		{
			/*
			Piece poppedPiece = board.RemovePiece( coords[0] );
			board.PlacePiece( poppedPiece, coords[1] );
			*/

			return true;
		}
	}
}

