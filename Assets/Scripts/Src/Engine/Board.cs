using System;
using System.Collections;
using System.Collections.Generic; 

namespace BitterBloom.ChessGame.Engine
{
	public class Board
	{
		private List<Tile> tiles;

		public Board()
		{
			tiles = new List<Tile>();
		}

		/**
		 * Populate tiles list with Tile objects and define their name and position in the board.
		 */
		public void Initialize()
		{
			string[] horizontalTiles	= new string[] { "A", "B", "C", "D", "E", "F", "G", "H" };
			string[] verticalTiles		= new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };

			int hPosition = 0;
			foreach( string hTile in horizontalTiles )
			{
				int vPosition = 0;
				foreach( string vTile in verticalTiles )
				{
					string tileName = hTile + vTile;
					tiles.Add( new Tile( tileName, hPosition, vPosition ) );

					++vPosition;
				}

				++hPosition;
			}
		}

		public List<Tile> getTiles()
		{
			return this.tiles;
		}
	}
}
