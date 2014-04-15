using System;

namespace BitterBloom.ChessGame.Engine.Pieces
{
	public class Queen : Piece
	{
		private ConfigChess.PieceID pieceID;

		public Queen( ConfigChess.PieceID pieceID )
		{
			this.pieceID = pieceID;
		}

		public ConfigChess.PieceID PieceID {
			get{ return this.pieceID; }
		}
	}
}
