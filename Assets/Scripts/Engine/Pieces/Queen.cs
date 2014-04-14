using System;

namespace BitterBloom.ChessGame.Engine
{
	public class Queen : Piece
	{
		private ChessEngine.PieceID pieceID;

		public Queen( ChessEngine.PieceID pieceID )
		{
			this.pieceID = pieceID;
		}

		public ChessEngine.PieceID PieceID
		{
			get{ return this.pieceID; }
		}
	}
}
