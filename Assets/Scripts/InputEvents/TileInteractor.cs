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
			string coord = this.name.Substring( 5 );

			/*
				What do I need to know?
					- Which tile has been clicked? --> get Coord
					- Is this tile occupied by a piece?
					- Which piece is it? --> get GameObject
					- Ask Engine what movements are allowed to that piece.
					- Display allowed movements
					- Which tile has been clicked?
					- Is it a tile in the list of allowed movements?
					- Move piece to the target.
					
			*/

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

