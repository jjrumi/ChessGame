using System;

namespace BitterBloom.ChessGame.Engine
{
	public class Tile
	{
		public string name;
		public int hPosition;
		public int vPosition;

		public Tile( string tileName, int hPosition, int vPosition )
		{
			this.name = tileName;
			this.hPosition = hPosition;
			this.vPosition = vPosition;
		}
	}
}

