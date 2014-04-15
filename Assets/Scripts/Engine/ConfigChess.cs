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
		// TODO: Is it really necessary to ID all the pieces. Should it suffice with just the types?
		public enum PieceID
		{
			PawnA,
			PawnB,
			PawnC,
			PawnD,
			PawnE,
			PawnF,
			PawnG,
			PawnH,
			QueensRook,
			QueensKnight,
			QueensBishop,
			Queen,
			King,
			KingsBishop,
			KingsKnight,
			KingsRook
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
			whiteSetPieces.Add( new Pawn( PieceID.PawnA ), "A2" );
			whiteSetPieces.Add( new Pawn( PieceID.PawnB ), "B2" );
			whiteSetPieces.Add( new Pawn( PieceID.PawnC ), "C2" );
			whiteSetPieces.Add( new Pawn( PieceID.PawnD ), "D2" );
			whiteSetPieces.Add( new Pawn( PieceID.PawnE ), "E2" );
			whiteSetPieces.Add( new Pawn( PieceID.PawnF ), "F2" );
			whiteSetPieces.Add( new Pawn( PieceID.PawnG ), "G2" );
			whiteSetPieces.Add( new Pawn( PieceID.PawnH ), "H2" );
			whiteSetPieces.Add( new Rook( PieceID.QueensRook ), "A1" );
			whiteSetPieces.Add( new Knight( PieceID.QueensKnight ), "B1" );
			whiteSetPieces.Add( new Bishop( PieceID.QueensBishop ), "C1" );
			whiteSetPieces.Add( new Queen( PieceID.Queen ), "D1" );
			whiteSetPieces.Add( new King( PieceID.King ), "E1" );
			whiteSetPieces.Add( new Bishop( PieceID.KingsBishop ), "F1" );
			whiteSetPieces.Add( new Knight( PieceID.KingsKnight ), "G1" );
			whiteSetPieces.Add( new Rook( PieceID.KingsRook ), "H1" );

			return whiteSetPieces;
		}

		/**
		 * Create black player's pieces with their initial position.
		 */
		public Dictionary<Piece, string> ListClassicLocationForBlackPieces()
		{
			Dictionary<Piece, string> blackSetPieces = new Dictionary<Piece, string>();
			blackSetPieces.Add( new Pawn( PieceID.PawnA ), "A7" );
			blackSetPieces.Add( new Pawn( PieceID.PawnB ), "B7" );
			blackSetPieces.Add( new Pawn( PieceID.PawnC ), "C7" );
			blackSetPieces.Add( new Pawn( PieceID.PawnD ), "D7" );
			blackSetPieces.Add( new Pawn( PieceID.PawnE ), "E7" );
			blackSetPieces.Add( new Pawn( PieceID.PawnF ), "F7" );
			blackSetPieces.Add( new Pawn( PieceID.PawnG ), "G7" );
			blackSetPieces.Add( new Pawn( PieceID.PawnH ), "H7" );
			blackSetPieces.Add( new Rook( PieceID.QueensRook ), "A8" );
			blackSetPieces.Add( new Knight( PieceID.QueensKnight ), "B8" );
			blackSetPieces.Add( new Bishop( PieceID.QueensBishop ), "C8" );
			blackSetPieces.Add( new Queen( PieceID.Queen ), "D8" );
			blackSetPieces.Add( new King( PieceID.King ), "E8" );
			blackSetPieces.Add( new Bishop( PieceID.KingsBishop ), "F8" );
			blackSetPieces.Add( new Knight( PieceID.KingsKnight ), "G8" );
			blackSetPieces.Add( new Rook( PieceID.KingsRook ), "H8" );

			return blackSetPieces;
		}
	}
}

