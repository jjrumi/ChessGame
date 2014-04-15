using System;
using BitterBloom.ChessGame.Engine.Pieces;

namespace BitterBloom.ChessGame.Engine
{
	public interface ITile
	{
		void PlacePiece( Piece piece );

		bool IsEmpty();

		string Name { get; }
	}
}

