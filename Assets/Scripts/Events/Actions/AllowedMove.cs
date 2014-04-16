using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BitterBloom.ChessGame.GUI;

namespace BitterBloom.ChessGame.Events.Actions
{
	public class AllowedMove
	{
		private BoardConfig boardConfig;
		private GameObjectFactory gof;
		private static Dictionary<string, GameObject> listMoves = new Dictionary<string, GameObject>();

		public AllowedMove( BoardConfig boardConfig, GameObjectFactory gof )
		{
			this.boardConfig = boardConfig;
			this.gof = gof;
		}

		public void DrawTileList( ArrayList moves )
		{
			foreach( string targetCoord in moves )
			{
				DrawTile( targetCoord );
			}
		}

		/**
		 * Create a new tile to be placed on top of the target coordinate.
		 * 
		 * The new tile will be a bit smaller, of a different color and closer to the camera (OZ).
		 */
		private void DrawTile( string targetCoord )
		{
			GameObject targetTile = boardConfig.GetTileFromCoord( targetCoord );
			Vector2 tilePosition = boardConfig.GetPositionFromTileCoord( targetCoord );
			GameObject allowedTile = gof.buildTile( "Allow_" + targetCoord, tilePosition );

			allowedTile.renderer.material = TileRenderer.GetMaterial( TileRenderer.LightYellow );
			allowedTile.transform.position = new Vector3( tilePosition.x, tilePosition.y, targetTile.transform.position.z - 1 );
			allowedTile.transform.localScale -= new Vector3( 0.08f, 0.08f, 0f );

			AllowedMove.listMoves.Add( targetCoord, allowedTile );
		}

		public bool IsAnAllowedMove( string coord )
		{
			return AllowedMove.listMoves.ContainsKey( coord );
		}

		public void DestroyAllowedTiles()
		{
			foreach( KeyValuePair<string, GameObject> entry in AllowedMove.listMoves )
			{
				UnityEngine.Object.Destroy( entry.Value );
			}

			AllowedMove.listMoves.Clear();
		}
	}
}

