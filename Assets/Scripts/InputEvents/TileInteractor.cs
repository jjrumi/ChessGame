using System;
using UnityEngine;
using BitterBloom.ChessGame.Engine;

namespace BitterBloom.ChessGame
{
	/**
	 * Logic related with a tile GameObject.
	 * 
	 * Input events like mouse clicks that interact with a tile are handled here.
	 */
	public class TileInteractor : MonoBehaviour
	{
		void OnMouseDown()
		{
			Debug.Log( "OnMouseDown detected!!" );
			string coord = this.name.Substring( 5 );

			if( Main.Move[0].Length == 0 )
			{
				Main.Move[0] = coord;
			}
			else
			{
				Main.Move[1] = coord;

				Main main = GameObject.Find( "GameEngine" ).GetComponent<Main>();
				if( main.chess.MovePiece( Main.Move ) )
				{
					// Update pieces position.
				}
			}
		}
	}
}

