using System;
using System.Collections.Generic;

namespace BitterBloom.ChessGame.Engine
{
	public class Player
	{
		private ChessEngine.PlayerColor color;
		private Dictionary<Piece, string> setPieces;

		public Player( ChessEngine.PlayerColor color )
		{
			this.color = color;
			setPieces = new Dictionary<Piece, string>();
		}

		public ChessEngine.PlayerColor Color
		{
			get{ return this.color; }
		}

		public Dictionary<Piece, string> Pieces
		{
			get{ return this.setPieces; }
			set{ this.setPieces = value; }
		}
	}
}

