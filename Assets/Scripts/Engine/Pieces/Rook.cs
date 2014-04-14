using System;

namespace BitterBloom.ChessGame.Engine.Pieces
{
	public class Rook : Piece
	{
		private ChessEngine.PieceID pieceID;

		public Rook( ChessEngine.PieceID pieceID )
		{
			this.pieceID = pieceID;
		}

		public ChessEngine.PieceID PieceID
		{
			get{ return this.pieceID; }
		}
	}
}