using System;

namespace BitterBloom.ChessGame.Engine
{
	public class Tile
	{
		public string name;
		private Piece piece;

		public Tile( string name )
		{
			this.name = name;
			this.piece = null;
		}

		public void PlacePiece( Piece piece )
		{
			this.piece = piece;
		}

		public bool IsEmpty()
		{
			return this.piece == null;
		}
	}
}

