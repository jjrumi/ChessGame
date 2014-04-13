using System;
using UnityEngine;

namespace BitterBloom.ChessGame
{
	public class GameObjectFactory
	{
		public GameObject buildTile( string objName, int hPosition, int vPosition )
		{
			GameObject tile = new GameObject( "Tile_" + objName );
			attachMeshToTile( tile );
			attachMaterialToTile( tile, ( hPosition + vPosition ) );

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
		private void attachMaterialToTile( GameObject tile, int tileIndex )
		{
			Material[] tileMaterials = new Material[] { 
				Resources.Load( "Materials/Dark-brown", typeof( Material ) ) as Material, 
				Resources.Load( "Materials/Light-brown", typeof( Material ) ) as Material
			};

			tile.renderer.material = ( tileIndex  % 2 ) == 0 ? tileMaterials[0] : tileMaterials[1];
		}
	}
}

