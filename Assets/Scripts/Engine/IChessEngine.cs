using System;
using System.Collections;

namespace BitterBloom.ChessGame.Engine
{
	public interface IChessEngine
	{
		void Initialize();

		ArrayList GetBoardTiles();

		ArrayList GetChessPieces();

		bool MovePiece( string[] coords );
	}
}

