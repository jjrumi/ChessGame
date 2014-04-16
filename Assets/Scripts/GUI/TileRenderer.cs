﻿using System;
using UnityEngine;

namespace BitterBloom.ChessGame.GUI
{
	public class TileRenderer
	{
		public const int DarkBrown = 0;
		public const int LightBrown = 1;
		public const int LightYellow = 2;
		private static Material[] tileMaterials = new Material[] { 
			Resources.Load( "Materials/Dark-brown", typeof( Material ) ) as Material, 
			Resources.Load( "Materials/Light-brown", typeof( Material ) ) as Material,
			Resources.Load( "Materials/Light-yellow", typeof( Material ) ) as Material
		};

		public static Material GetMaterial( int materialIdx )
		{
			if( TileRenderer.tileMaterials[materialIdx] != null )
			{
				return TileRenderer.tileMaterials[materialIdx];
			}

			return null;
		}

		/**
		 * Retrieve material on the tile position in the board to obtain an harlequin board.
		 */
		public static Material GetMaterialForHarlequin( float index )
		{
			return ( index % 2 ) == 0 ? TileRenderer.GetMaterial( TileRenderer.DarkBrown ) : TileRenderer.GetMaterial( TileRenderer.LightBrown );
		}
	}
}

