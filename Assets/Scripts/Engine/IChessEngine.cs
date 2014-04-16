using System;
using System.Collections;

namespace BitterBloom.ChessGame.Engine
{
	public interface IChessEngine
	{
		void Initialize();

		ArrayList GetBoardTiles();

		ArrayList GetChessPieces();

		ArrayList GetAllowedMoves( string coord );

		bool MovePiece( string[] coords );
	}
}

