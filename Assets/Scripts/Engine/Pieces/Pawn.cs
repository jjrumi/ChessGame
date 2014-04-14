using System;

namespace BitterBloom.ChessGame.Engine.Pieces
{
	public class Pawn : Piece
	{
		private ChessEngine.PieceID pieceID;

		public Pawn( ChessEngine.PieceID pieceID )
		{
			this.pieceID = pieceID;
		}

		public ChessEngine.PieceID PieceID
		{
			get{ return this.pieceID; }
		}
	}
}
