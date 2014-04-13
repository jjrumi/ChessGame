using System;
using System.Collections.Generic;

namespace BitterBloom.ChessGame.Engine
{
	public class Player
	{
		public enum Color { White, Black };

		private Color color;
		private Dictionary<ChessEngine.PieceID, Piece> setPieces;

		public Player( Color color )
		{
			this.color = color;
			setPieces = new Dictionary<ChessEngine.PieceID, Piece>();
		}

		public void Initialize()
		{
			createSetPieces();
		}

		private void createSetPieces()
		{
			setPieces.Add( ChessEngine.PieceID.PawnA, new Pawn( ChessEngine.PieceID.PawnA ) );
			setPieces.Add( ChessEngine.PieceID.PawnB, new Pawn( ChessEngine.PieceID.PawnB ) );
			setPieces.Add( ChessEngine.PieceID.PawnC, new Pawn( ChessEngine.PieceID.PawnC ) );
			setPieces.Add( ChessEngine.PieceID.PawnD, new Pawn( ChessEngine.PieceID.PawnD ) );
			setPieces.Add( ChessEngine.PieceID.PawnE, new Pawn( ChessEngine.PieceID.PawnE ) );
			setPieces.Add( ChessEngine.PieceID.PawnF, new Pawn( ChessEngine.PieceID.PawnF ) );
			setPieces.Add( ChessEngine.PieceID.PawnG, new Pawn( ChessEngine.PieceID.PawnG ) );
			setPieces.Add( ChessEngine.PieceID.PawnH, new Pawn( ChessEngine.PieceID.PawnH ) );

			setPieces.Add( ChessEngine.PieceID.QueensRook, new Rook( ChessEngine.PieceID.QueensRook ) );
			setPieces.Add( ChessEngine.PieceID.QueensKnight, new Knight( ChessEngine.PieceID.QueensKnight ) );
			setPieces.Add( ChessEngine.PieceID.QueensBishop, new Bishop( ChessEngine.PieceID.QueensBishop ) );
			setPieces.Add( ChessEngine.PieceID.Queen, new Queen( ChessEngine.PieceID.Queen ) );
			setPieces.Add( ChessEngine.PieceID.King, new King( ChessEngine.PieceID.King ) );
			setPieces.Add( ChessEngine.PieceID.KingsBishop, new Bishop( ChessEngine.PieceID.KingsBishop ) );
			setPieces.Add( ChessEngine.PieceID.KingsKnight, new Knight( ChessEngine.PieceID.KingsKnight ) );
			setPieces.Add( ChessEngine.PieceID.KingsRook, new Rook( ChessEngine.PieceID.KingsRook ) );
		}

		public Dictionary<ChessEngine.PieceID, Piece> Pieces
		{
			get{ return this.setPieces; }
		}
	}
}

