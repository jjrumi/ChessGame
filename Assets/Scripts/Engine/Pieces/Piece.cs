using System;

namespace BitterBloom.ChessGame.Engine.Pieces
{
	public interface Piece
	{
		//string getPieceType();
		ConfigChess.PieceID PieceID {
			get;
		}
	}
}

