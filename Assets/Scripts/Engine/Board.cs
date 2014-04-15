using System;
using System.Collections;
using System.Collections.Generic;
using BitterBloom.ChessGame.Engine.Pieces;

namespace BitterBloom.ChessGame.Engine
{
	public class Board : IBoard
	{
		private Dictionary<string, ITile> tiles;

		public void Initialize( string[] horizontalCoords, string[] verticalCoords )
		{
			CreateTiles( horizontalCoords, verticalCoords );
		}

		/**
		 * Populate tiles list with Tile objects and define their unique name: A1, A2, ..., C3, ..., H8.
		 */
		private void CreateTiles( string[] horizontalCoords, string[] verticalCoords )
		{
			tiles = new Dictionary<string, ITile>();
			foreach( string hTile in horizontalCoords )
			{
				foreach( string vTile in verticalCoords )
				{
					string tileName = hTile + vTile;
					tiles.Add( tileName, new Tile( tileName ) );
				}
			}
		}

		/**
		 * Checks if the tile for the given coord has a linked piece.
		 */
		public bool IsTileEmpty( string coord )
		{
			return tiles[coord].IsEmpty();
		}

		/**
		 * Place a piece on the given coordinate of the board.
		 */
		public void PlacePiece( Piece piece, string coord )
		{
			if( !IsTileEmpty( coord ) )
			{
				throw new TargetTileOccupiedException();
			}

			tiles[coord].PlacePiece( piece );
		}

		public Piece RemovePiece( string coord )
		{
			if( IsTileEmpty( coord ) )
			{
				throw new TargetTileEmptyException();
			}

			Piece poppedPiece = tiles[coord].RemovePiece();
			return poppedPiece;
		}

		/**
		 * Given a collection of [Piece => coord], place the pieces on the board.
		 */
		public void PlaceCollectionOfPieces( Dictionary<Piece, string> setPieces )
		{
			foreach( KeyValuePair<Piece, string> entry in setPieces )
			{
				PlacePiece( entry.Key, entry.Value );
			}
		}

		/**
		 * List tiles information: [TileID].
		 */
		public ArrayList ListBoardTiles()
		{
			ArrayList list = new ArrayList();
			foreach( KeyValuePair<string, ITile> entry in tiles )
			{
				list.Add( entry.Value.Name );
			}

			return list;
		}

		public Dictionary<string, ITile> Tiles {
			get{ return this.tiles; }
			set{ this.tiles = value; }
		}

		public class TargetTileOccupiedException : ApplicationException
		{
		}

		public class TargetTileEmptyException : ApplicationException
		{
		}
	}
}
