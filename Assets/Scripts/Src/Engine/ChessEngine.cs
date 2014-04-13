using System;
using System.Collections;
using System.Collections.Generic;

namespace BitterBloom.ChessGame.Engine
{
	public class ChessEngine
	{
		private Board board;

		public ChessEngine()
		{
			board = new Board();
		}

		public void Initialize()
		{
			board.Initialize();
		}

		public List<Tile> getBoardTiles()
		{
			return board.getTiles();
		}
	}
}

