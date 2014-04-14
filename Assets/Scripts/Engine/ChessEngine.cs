using System;
using System.Collections;
using System.Collections.Generic;

namespace BitterBloom.ChessGame.Engine
{
	public class ChessEngine
	{
		public enum PlayerColor { White, Black };

		public enum PieceID { 
			PawnA, 		PawnB,			PawnC,			PawnD,	PawnE,	PawnF,			PawnG,			PawnH, 
			QueensRook,	QueensKnight,	QueensBishop,	Queen,	King,	KingsBishop,	KingsKnight,	KingsRook
		};

		private Board board;
		private Player white;
		private Player black;

		public ChessEngine()
		{
			board = new Board();
			white = new Player( PlayerColor.White );
			black = new Player( PlayerColor.Black );
		}

		/**
		 * Setup board, tiles and pieces logic.
		 */
		public void Initialize()
		{
			board.Initialize();
			Dictionary<Piece, string> whitePieces = defineWhitePiecesLocationOnBoard();
			Dictionary<Piece, string> blackPieces = defineBlackPiecesLocationOnBoard();
			board.PlaceListOfPieces( whitePieces );
			board.PlaceListOfPieces( blackPieces );
			white.Pieces = whitePieces;
			black.Pieces = blackPieces;
		}

		/**
		 * Create white player's pieces with their initial position.
		 */
		private Dictionary<Piece, string> defineWhitePiecesLocationOnBoard()
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
		private Dictionary<Piece, string> defineBlackPiecesLocationOnBoard()
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

		public ArrayList getBoardTiles()
		{
			ArrayList list = new ArrayList();
			foreach( KeyValuePair<string, Tile> entry in board.Tiles )
			{
				list.Add( entry.Value.name );
			}

			return list;
		}

		public ArrayList getChessPieces()
		{
			ArrayList list = new ArrayList();

			// White pieces:
			foreach( KeyValuePair<Piece, string> entry in white.Pieces )
			{
				string[] tuple = { white.Color.ToString(), entry.Key.GetType().Name, entry.Value };

				list.Add( tuple );
			}

			// Black pieces:
			foreach( KeyValuePair<Piece, string> entry in black.Pieces )
			{
				string[] tuple = { black.Color.ToString(), entry.Key.GetType().Name, entry.Value };

				list.Add( tuple );
			}

			return list;
		}

	}
}

