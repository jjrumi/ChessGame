using System;
using System.Collections;
using UnityEngine;
using BitterBloom.ChessGame.Engine;
using BitterBloom.ChessGame.GUI;
using BitterBloom.ChessGame.Events.Actions;

namespace BitterBloom.ChessGame.Events
{
	/**
	 * Logic related with a tile GameObject.
	 * 
	 * Input events like mouse clicks that interact with a tile are handled here.
	 */
	public class TileEvent : MonoBehaviour
	{
		/**
		 * Event triggered when a GameObject+Collider has detected an "OnMouseDown" on it.
		 * 
		 * The current instance is the Script component attached to the GameObject that has detected the event.
		 */
		private void OnMouseDown()
		{
			MoveFlow flow = new MoveFlow( 
				                GameObject.Find( "GameEngine" ).GetComponent<Main>().boardConfig, 
				                GameObject.Find( "GameEngine" ).GetComponent<Main>().chess, 
				                GameObject.Find( "GameEngine" ).GetComponent<Main>().gof
			                );

			flow.Execute( GetHitTileCoord( this.gameObject ) );
		}

		/**
		 * Tile coordinate are the last two characters of its GameObject name.
		 */
		private string GetHitTileCoord( GameObject obj )
		{
			return obj.name.Substring( obj.name.Length - 2 );
		}
	}
}

