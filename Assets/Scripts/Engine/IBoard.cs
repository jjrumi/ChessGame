using System;
using System.Collections;
using System.Collections.Generic;
using BitterBloom.ChessGame.Engine.Pieces;

namespace BitterBloom.ChessGame.Engine
{
	public interface IBoard
	{
		void Initialize( string[] horizontalCoords, string[] verticalCoords );

		void PlacePiece( Piece piece, string coordinates );

		Piece RemovePiece( string coord );

		void PlaceCollectionOfPieces( Dictionary<Piece, string> setPieces );

		ArrayList ListBoardTiles();
	}
}

