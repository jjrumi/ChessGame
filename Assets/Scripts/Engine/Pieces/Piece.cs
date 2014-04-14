using System;

namespace BitterBloom.ChessGame.Engine.Pieces
{
	public interface Piece
	{
		//string getPieceType();

		ChessEngine.PieceID PieceID
		{
			get;
		}
	}
}

