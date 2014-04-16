using System;
using System.Collections.Generic;
using UnityEngine;
using BitterBloom.ChessGame.Events;

namespace BitterBloom.ChessGame.GUI
{
	public class GameObjectFactory
	{
		public GameObject buildTile( string objName, Vector2 tilePosition )
		{
			GameObject tile = new GameObject( "Tile_" + objName );
			attachMeshToTile( tile );
			attachInputInteraction( tile );

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
			tile.renderer.material = ( tileIndex % 2 ) == 0 ? TileRenderer.GetMaterial( TileRenderer.DarkBrown ) : TileRenderer.GetMaterial( TileRenderer.LightBrown );
		}

		/**
		 * Attach a script to handle the input interactions with the GameObject and a Collider to detect those interactions.
		 */
		private void attachInputInteraction( GameObject tile )
		{
			tile.AddComponent<TileEvent>();
			tile.AddComponent<BoxCollider2D>();
		}

		public GameObject buildChessPiece( string pieceColor, string pieceType )
		{
			GameObject piece = new GameObject( pieceColor + '_' + pieceType );

			attachSpriteToPiece( piece, pieceColor, pieceType );

			return piece;
		}

		/**
		 * Attach a sprite component to the GameObject and scale it to make it bigger and look nicer.
		 */
		private void attachSpriteToPiece( GameObject piece, string pieceColor, string pieceType )
		{
			piece.AddComponent<SpriteRenderer>();
			piece.GetComponent<SpriteRenderer>().sprite = PieceRenderer.GetSprite( pieceColor, pieceType );
			piece.transform.localScale += new Vector3( 0.4f, 0.4f, 0 );
		}
	}
}

