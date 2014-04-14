using System;

namespace BitterBloom.ChessGame.Engine.Pieces
{
	public class King : Piece
	{
		private ChessEngine.PieceID pieceID;

		public King( ChessEngine.PieceID pieceID )
		{
			this.pieceID = pieceID;
		}

		public ChessEngine.PieceID PieceID
		{
			get{ return this.pieceID; }
		}
	}
}
