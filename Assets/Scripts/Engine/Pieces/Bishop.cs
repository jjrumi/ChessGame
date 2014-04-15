using System;

namespace BitterBloom.ChessGame.Engine.Pieces
{
	public class Bishop : Piece
	{
		private ConfigChess.PieceID pieceID;

		public Bishop( ConfigChess.PieceID pieceID )
		{
			this.pieceID = pieceID;
		}

		public ConfigChess.PieceID PieceID {
			get{ return this.pieceID; }
		}
	}
}
