using System;
using System.Collections;
using System.Collections.Generic;
using BitterBloom.ChessGame.Engine.Pieces;

namespace BitterBloom.ChessGame.Engine
{
	public interface IBoard
	{
		void Initialize();

		void PlacePiece( Piece piece, string coordinates );

		void PlaceListOfPieces( Dictionary<Piece, string> setPieces );

		ArrayList ListBoardTiles();
	}
}

