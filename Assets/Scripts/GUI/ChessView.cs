using System;
using UnityEngine;
using System.Collections;

namespace BitterBloom.ChessGame.GUI
{
	public class ChessView
	{
		private GameObjectFactory gof;
		private BoardConfig boardConfig;

		public ChessView( GameObjectFactory gof, BoardConfig boardConfig )
		{
			this.gof = gof;
			this.boardConfig = boardConfig;
		}

		/**
		 * Construct a GameObject for each board tile and place it in the world.
		 * 
		 * Initialize [tile,coord] relations in the BoardConfig.
		 */
		public void DrawBoardTiles( ArrayList tilesCoords )
		{
			foreach( string coord in tilesCoords )
			{
				Vector2 tilePosition = boardConfig.GetPositionFromTileCoord( coord );

				GameObject tile = gof.buildTile( coord, tilePosition );
				tile.renderer.material = TileRenderer.GetMaterialForHarlequin( tilePosition.x + tilePosition.y );
				tile.transform.position = new Vector3( tilePosition.x, tilePosition.y, 5.0f );

				boardConfig.AddCoordToTileInMap( coord, tile );
			}
		}

		/**
		 * Construct a GameObject for each chess piece and place it in the world.
		 * 
		 * Initialize [piece,coord] relations in the BoardConfig.
		 */
		public void DrawBoardPieces( ArrayList pieces )
		{
			foreach( string[] pieceInfo in pieces )
			{
				string color = pieceInfo[0];
				string pieceType = pieceInfo[1];
				string coord = pieceInfo[2];

				GameObject piece = gof.buildChessPiece( color, pieceType );
				Vector2 piecePosition = boardConfig.GetPositionFromTileCoord( coord );
				piece.transform.position = new Vector3( piecePosition.x, piecePosition.y, 1.0f );

				boardConfig.AddCoordToPieceInMap( coord, piece );
			}
		}
	}
}

