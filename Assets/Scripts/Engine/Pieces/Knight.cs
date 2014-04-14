using System;

namespace BitterBloom.ChessGame.Engine.Pieces
{
	public class Knight : Piece
	{
		private ChessEngine.PieceID pieceID;

		public Knight( ChessEngine.PieceID pieceID )
		{
			this.pieceID = pieceID;
		}

		public ChessEngine.PieceID PieceID
		{
			get{ return this.pieceID; }
		}
	}
}
