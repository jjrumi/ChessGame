using System;
using System.Collections;
using System.Collections.Generic; 

namespace BitterBloom.ChessGame.Engine
{
	public class Board
	{
		private Dictionary<string, Tile> tiles;

		public Board()
		{
			tiles = new Dictionary<string, Tile>();
		}

		public void Initialize()
		{
			createTiles();
		}

		/**
		 * Populate tiles list with Tile objects and define their name and position in the board.
		 */
		private void createTiles()
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
					tiles.Add( tileName, new Tile( tileName, hPosition, vPosition ) );

					++vPosition;
				}

				++hPosition;
			}
		}

		/**
		 * Place a piece on the given coordinate of the board.
		 */
		public void PlacePiece( Piece piece, string coordinates )
		{
			if( !tiles[coordinates].isEmpty() )
			{
				throw new TargetTileOccupiedException();
			}

			tiles[coordinates].placePiece( piece );
		}

		public Dictionary<string, Tile> Tiles
		{
			get{ return this.tiles; }
		}

		public class TargetTileOccupiedException : ApplicationException{}
	}
}
