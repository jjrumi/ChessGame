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
			CreateTiles();
		}

		/**
		 * Populate tiles list with Tile objects and define their unique name: A1, A2, ..., C3, ..., H8.
		 */
		private void CreateTiles()
		{
			string[] horizontalTiles	= new string[] { "A", "B", "C", "D", "E", "F", "G", "H" };
			string[] verticalTiles		= new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };

			foreach( string hTile in horizontalTiles )
			{
				foreach( string vTile in verticalTiles )
				{
					string tileName = hTile + vTile;
					tiles.Add( tileName, new Tile( tileName ) );
				}
			}
		}

		/**
		 * Place a piece on the given coordinate of the board.
		 */
		public void PlacePiece( Piece piece, string coordinates )
		{
			if( !tiles[coordinates].IsEmpty() )
			{
				throw new TargetTileOccupiedException();
			}

			tiles[coordinates].PlacePiece( piece );
		}

		public void PlaceListOfPieces( Dictionary<Piece, string> setPieces )
		{
			foreach( KeyValuePair<Piece, string> entry in setPieces )
			{
				PlacePiece( entry.Key, entry.Value );
			}
		}

		public Dictionary<string, Tile> Tiles
		{
			get{ return this.tiles; }
		}

		public class TargetTileOccupiedException : ApplicationException{}
	}
}
