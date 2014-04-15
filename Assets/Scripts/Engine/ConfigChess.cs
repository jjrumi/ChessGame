using System;
using System.Collections;
using System.Collections.Generic;
using BitterBloom.ChessGame.Engine.Pieces;

namespace BitterBloom.ChessGame.Engine
{
	/**
	 * Defines configuration setups for a game of Chess.
	 */
	public class ConfigChess
	{
		public enum PieceID
		{
			Pawn,
			Rook,
			Knight,
			Bishop,
			Queen,
			King
		}

		public string[] ListHorizontalBoardCoordinates()
		{
			string[] horizontalCoords = { "A", "B", "C", "D", "E", "F", "G", "H" };
			return horizontalCoords;
		}

		public string[] ListVerticalBoardCoordinates()
		{
			string[] verticalTiles = { "1", "2", "3", "4", "5", "6", "7", "8" };
			return verticalTiles;
		}

		/**
		 * Create white player's pieces with their initial position.
		 */
		public Dictionary<Piece, string> ListClassicLocationForWhitePieces()
		{
			Dictionary<Piece, string> whiteSetPieces = new Dictionary<Piece, string>();
			whiteSetPieces.Add( new Pawn( PieceID.Pawn ), "A2" );
			whiteSetPieces.Add( new Pawn( PieceID.Pawn ), "B2" );
			whiteSetPieces.Add( new Pawn( PieceID.Pawn ), "C2" );
			whiteSetPieces.Add( new Pawn( PieceID.Pawn ), "D2" );
			whiteSetPieces.Add( new Pawn( PieceID.Pawn ), "E2" );
			whiteSetPieces.Add( new Pawn( PieceID.Pawn ), "F2" );
			whiteSetPieces.Add( new Pawn( PieceID.Pawn ), "G2" );
			whiteSetPieces.Add( new Pawn( PieceID.Pawn ), "H2" );
			whiteSetPieces.Add( new Rook( PieceID.Rook ), "A1" );
			whiteSetPieces.Add( new Knight( PieceID.Knight ), "B1" );
			whiteSetPieces.Add( new Bishop( PieceID.Bishop ), "C1" );
			whiteSetPieces.Add( new Queen( PieceID.Queen ), "D1" );
			whiteSetPieces.Add( new King( PieceID.King ), "E1" );
			whiteSetPieces.Add( new Bishop( PieceID.Bishop ), "F1" );
			whiteSetPieces.Add( new Knight( PieceID.Knight ), "G1" );
			whiteSetPieces.Add( new Rook( PieceID.Rook ), "H1" );

			return whiteSetPieces;
		}

		/**
		 * Create black player's pieces with their initial position.
		 */
		public Dictionary<Piece, string> ListClassicLocationForBlackPieces()
		{
			Dictionary<Piece, string> blackSetPieces = new Dictionary<Piece, string>();
			blackSetPieces.Add( new Pawn( PieceID.Pawn ), "A7" );
			blackSetPieces.Add( new Pawn( PieceID.Pawn ), "B7" );
			blackSetPieces.Add( new Pawn( PieceID.Pawn ), "C7" );
			blackSetPieces.Add( new Pawn( PieceID.Pawn ), "D7" );
			blackSetPieces.Add( new Pawn( PieceID.Pawn ), "E7" );
			blackSetPieces.Add( new Pawn( PieceID.Pawn ), "F7" );
			blackSetPieces.Add( new Pawn( PieceID.Pawn ), "G7" );
			blackSetPieces.Add( new Pawn( PieceID.Pawn ), "H7" );
			blackSetPieces.Add( new Rook( PieceID.Rook ), "A8" );
			blackSetPieces.Add( new Knight( PieceID.Knight ), "B8" );
			blackSetPieces.Add( new Bishop( PieceID.Bishop ), "C8" );
			blackSetPieces.Add( new Queen( PieceID.Queen ), "D8" );
			blackSetPieces.Add( new King( PieceID.King ), "E8" );
			blackSetPieces.Add( new Bishop( PieceID.Bishop ), "F8" );
			blackSetPieces.Add( new Knight( PieceID.Knight ), "G8" );
			blackSetPieces.Add( new Rook( PieceID.Rook ), "H8" );

			return blackSetPieces;
		}
	}
}

