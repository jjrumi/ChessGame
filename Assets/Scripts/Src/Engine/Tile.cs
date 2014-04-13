using System;

namespace BitterBloom.ChessGame.Engine
{
	public class Tile
	{
		public string name;
		public int hPosition;
		public int vPosition;
		private Piece piece;

		public Tile( string name, int hPosition, int vPosition )
		{
			this.name = name;
			this.hPosition = hPosition;
			this.vPosition = vPosition;
			this.piece = null;
		}

		public void placePiece( Piece piece )
		{
			this.piece = piece;
		}

		public bool isEmpty()
		{
			return this.piece == null;
		}

		public Piece Piece
		{
			get{ return this.piece; }
		}
	}
}

