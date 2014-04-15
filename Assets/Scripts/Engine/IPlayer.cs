using System;
using System.Collections;
using System.Collections.Generic;
using BitterBloom.ChessGame.Engine.Pieces;

namespace BitterBloom.ChessGame.Engine
{
	public interface IPlayer
	{
		ArrayList ListPieces();
		Dictionary<Piece, string> Pieces { get;set; }
	}
}

