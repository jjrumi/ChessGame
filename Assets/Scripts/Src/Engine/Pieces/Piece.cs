using System;

namespace BitterBloom.ChessGame.Engine
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

