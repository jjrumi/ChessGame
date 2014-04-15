using System;

namespace BitterBloom.ChessGame.Engine.Pieces
{
	public class King : Piece
	{
		private ConfigChess.PieceID pieceID;

		public King( ConfigChess.PieceID pieceID )
		{
			this.pieceID = pieceID;
		}

		public ConfigChess.PieceID PieceID {
			get{ return this.pieceID; }
		}
	}
}
