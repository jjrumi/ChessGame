using System;

namespace BitterBloom.ChessGame.Engine.Pieces
{
	public class Pawn : Piece
	{
		private ConfigChess.PieceID pieceID;

		public Pawn( ConfigChess.PieceID pieceID )
		{
			this.pieceID = pieceID;
		}

		public ConfigChess.PieceID PieceID {
			get{ return this.pieceID; }
		}
	}
}
