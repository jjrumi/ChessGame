using System;
using BitterBloom.ChessGame.Engine.Pieces;

namespace BitterBloom.ChessGame.Engine
{
	public class Tile : ITile
	{
		private string name;
		private Piece piece;

		public Tile( string name )
		{
			this.name = name;
		}

		public void PlacePiece( Piece piece )
		{
			this.piece = piece;
		}

		public Piece RemovePiece()
		{
			Piece poppedPiece = this.piece;
			this.piece = null;

			return poppedPiece;
		}

		public bool IsEmpty()
		{
			return this.piece == null;
		}

		public string Name { 
			get{ return this.name; }
		}
	}
}

