using System;

namespace BitterBloom.ChessGame.Engine.Pieces
{
	public class Knight : Piece
	{
		private ConfigChess.PieceID pieceID;

		public Knight( ConfigChess.PieceID pieceID )
		{
			this.pieceID = pieceID;
		}

		public ConfigChess.PieceID PieceID {
			get{ return this.pieceID; }
		}
	}
}
