using System;

namespace BitterBloom.ChessGame.Engine.Pieces
{
	public class Rook : Piece
	{
		private ConfigChess.PieceID pieceID;

		public Rook( ConfigChess.PieceID pieceID )
		{
			this.pieceID = pieceID;
		}

		public ConfigChess.PieceID PieceID {
			get{ return this.pieceID; }
		}
	}
}