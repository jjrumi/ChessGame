using System;
using System.Collections;
using System.Collections.Generic;

namespace BitterBloom.ChessGame.Engine
{
	public class ChessEngine
	{
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
			white = new Player( Player.Color.White );
			black = new Player( Player.Color.Black );
		}

		/**
		 * Setup board, tiles and pieces logic.
		 */
		public void Initialize()
		{
			white.Initialize();
			black.Initialize();
			board.Initialize();
			placePiecesOnBoard();
		}

		/**
		 * Set the player's pieces on the board with the help of a Hash who defines the starting piece location:
		 *	For white player:
		 *		QueensRook -> A1
		 *		QueensKnight -> B1 
		 *		...
		 *
		 *	For black player:
		 *		QueensRook -> A8 
		 *		QueensKnight -> B8 
		 *		...
		 */
		private void placePiecesOnBoard()
		{
			Dictionary<PieceID, string> whiteSetPiecesStartLocation = new Dictionary<PieceID, string>();
			whiteSetPiecesStartLocation.Add( PieceID.PawnA, "A2" );
			whiteSetPiecesStartLocation.Add( PieceID.PawnB, "B2" );
			whiteSetPiecesStartLocation.Add( PieceID.PawnC, "C2" );
			whiteSetPiecesStartLocation.Add( PieceID.PawnD, "D2" );
			whiteSetPiecesStartLocation.Add( PieceID.PawnE, "E2" );
			whiteSetPiecesStartLocation.Add( PieceID.PawnF, "F2" );
			whiteSetPiecesStartLocation.Add( PieceID.PawnG, "G2" );
			whiteSetPiecesStartLocation.Add( PieceID.PawnH, "H2" );
			whiteSetPiecesStartLocation.Add( PieceID.QueensRook, "A1" );
			whiteSetPiecesStartLocation.Add( PieceID.QueensKnight, "B1" );
			whiteSetPiecesStartLocation.Add( PieceID.QueensBishop, "C1" );
			whiteSetPiecesStartLocation.Add( PieceID.Queen, "D1" );
			whiteSetPiecesStartLocation.Add( PieceID.King, "E1" );
			whiteSetPiecesStartLocation.Add( PieceID.KingsBishop, "F1" );
			whiteSetPiecesStartLocation.Add( PieceID.KingsKnight, "G1" );
			whiteSetPiecesStartLocation.Add( PieceID.KingsRook, "H1" );

			Dictionary<PieceID, string> blackSetPiecesStartLocation = new Dictionary<PieceID, string>();
			blackSetPiecesStartLocation.Add( PieceID.PawnA, "A7" );
			blackSetPiecesStartLocation.Add( PieceID.PawnB, "B7" );
			blackSetPiecesStartLocation.Add( PieceID.PawnC, "C7" );
			blackSetPiecesStartLocation.Add( PieceID.PawnD, "D7" );
			blackSetPiecesStartLocation.Add( PieceID.PawnE, "E7" );
			blackSetPiecesStartLocation.Add( PieceID.PawnF, "F7" );
			blackSetPiecesStartLocation.Add( PieceID.PawnG, "G7" );
			blackSetPiecesStartLocation.Add( PieceID.PawnH, "H7" );
			blackSetPiecesStartLocation.Add( PieceID.QueensRook, "A8" );
			blackSetPiecesStartLocation.Add( PieceID.QueensKnight, "B8" );
			blackSetPiecesStartLocation.Add( PieceID.QueensBishop, "C8" );
			blackSetPiecesStartLocation.Add( PieceID.Queen, "D8" );
			blackSetPiecesStartLocation.Add( PieceID.King, "E8" );
			blackSetPiecesStartLocation.Add( PieceID.KingsBishop, "F8" );
			blackSetPiecesStartLocation.Add( PieceID.KingsKnight, "G8" );
			blackSetPiecesStartLocation.Add( PieceID.KingsRook, "H8" );

			// Place White player pieces.
			foreach( KeyValuePair<PieceID, Piece> entry in white.Pieces )
			{
				if( whiteSetPiecesStartLocation.ContainsKey( entry.Key ) )
				{
					board.PlacePiece( entry.Value, whiteSetPiecesStartLocation[entry.Key] );
				}
			}

			// Place Black player pieces.
			foreach( KeyValuePair<PieceID, Piece> entry in black.Pieces )
			{
				if( blackSetPiecesStartLocation.ContainsKey( entry.Key ) )
				{
					board.PlacePiece( entry.Value, blackSetPiecesStartLocation[entry.Key] );
				}
			}
		}

		public Dictionary<string, Tile> getBoardTiles()
		{
			return board.Tiles;
		}
	}
}

