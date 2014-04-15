using System;
using UnityEngine;
using System.Collections.Generic;

namespace BitterBloom.ChessGame
{
	public class GameObjectFactory
	{
		private Material[] tileMaterials;
		private Sprite[] chessPiecesSprite;

		public GameObjectFactory()
		{
			tileMaterials = new Material[] { 
				Resources.Load( "Materials/Dark-brown", typeof( Material ) ) as Material, 
				Resources.Load( "Materials/Light-brown", typeof( Material ) ) as Material
			};

			chessPiecesSprite = Resources.LoadAll<Sprite>( "Sprites/pieces-sprite" );
		}

		public GameObject buildTile( string objName, Vector2 tilePosition )
		{
			GameObject tile = new GameObject( "Tile_" + objName );
			attachMeshToTile( tile );
			attachMaterialToTile( tile, ( tilePosition.x + tilePosition.y ) );

			return tile;
		}

		/**
		 * Attach a plane-mesh to the given tile.
		 */
		private void attachMeshToTile( GameObject tile )
		{
			int tileSize = 1;

			tile.AddComponent<MeshRenderer>();
			tile.AddComponent<MeshFilter>().mesh = MeshGenerator.CreatePlaneMesh( tile.name, tileSize, tileSize );
		}

		/**
		 * Attach a material to the given tile based on the tile position in the board to obtain alternate colors.
		 */
		private void attachMaterialToTile( GameObject tile, float tileIndex )
		{
			tile.renderer.material = ( tileIndex % 2 ) == 0 ? tileMaterials[0] : tileMaterials[1];
		}

		public GameObject buildChessPiece( string color, string pieceType )
		{
			GameObject piece = new GameObject( color + '_' + pieceType );
			piece.AddComponent<SpriteRenderer>();

			int spriteIndex = getSpritePositionFromPieceColorAndType( color, pieceType );
			piece.GetComponent<SpriteRenderer>().sprite = chessPiecesSprite[spriteIndex];
			piece.transform.localScale += new Vector3( 0.4f, 0.4f, 0 );

			return piece;
		}

		int getSpritePositionFromPieceColorAndType( string color, string type )
		{
			Dictionary<string, int> mapPieceInfoToSprite = new Dictionary<string, int>();
			mapPieceInfoToSprite.Add( "White_Pawn", 0 );
			mapPieceInfoToSprite.Add( "White_Bishop", 1 );
			mapPieceInfoToSprite.Add( "White_Knight", 2 );
			mapPieceInfoToSprite.Add( "White_Rook", 3 );
			mapPieceInfoToSprite.Add( "White_Queen", 4 );
			mapPieceInfoToSprite.Add( "White_King", 5 );

			mapPieceInfoToSprite.Add( "Black_Pawn", 6 );
			mapPieceInfoToSprite.Add( "Black_Bishop", 7 );
			mapPieceInfoToSprite.Add( "Black_Knight", 8 );
			mapPieceInfoToSprite.Add( "Black_Rook", 9 );
			mapPieceInfoToSprite.Add( "Black_Queen", 10 );
			mapPieceInfoToSprite.Add( "Black_King", 11 );

			return mapPieceInfoToSprite[color + '_' + type];
		}
	}
}

