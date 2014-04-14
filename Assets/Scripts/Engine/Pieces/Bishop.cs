using System;

namespace BitterBloom.ChessGame.Engine.Pieces
{
	public class Bishop : Piece
	{
		private ChessEngine.PieceID pieceID;

		public Bishop( ChessEngine.PieceID pieceID )
		{
			this.pieceID = pieceID;
		}

		public ChessEngine.PieceID PieceID
		{
			get{ return this.pieceID; }
		}
	}
}
