using System;
using BitterBloom.ChessGame.Engine.Pieces;

namespace BitterBloom.ChessGame.Engine
{
	public interface ITile
	{
		void PlacePiece( Piece piece );

		Piece RemovePiece();

		bool IsEmpty();

		string Name { get; }
	}
}

