using System;
using System.Collections;
using UnityEngine;
using BitterBloom.ChessGame.Engine;
using BitterBloom.ChessGame.GUI;

namespace BitterBloom.ChessGame
{
	/**
	 * Logic related with a tile GameObject.
	 * 
	 * Input events like mouse clicks that interact with a tile are handled here.
	 */
	public class TileInteractor : MonoBehaviour
	{
		private BoardConfig boardConfig;
		private IChessEngine chess;
		private GameObjectFactory gof;

		private enum MoveStatus {
			Rest,
			Piece,
			Target
		}

		private static ArrayList allowedMoves = new ArrayList();
		private static MoveStatus moveStatus = MoveStatus.Rest;
		private static GameObject selectedPiece;

		/**
		 * Event triggered when a GameObject+Collider has detected an "OnMouseDown" on it.
		 * 
		 * The current instance is the Script component attached to the GameObject that has detected the event.
		 */
		void OnMouseDown()
		{
			LoadAppComponents();

			string coord = this.name.Substring( this.name.Length - 2 );

			switch( moveStatus )
			{
				case MoveStatus.Rest:
					PlayerPicksAPiece( coord );
					break;

				case MoveStatus.Piece:
					PlayerPicksATarget( coord );
					break;

				case MoveStatus.Target:
					break;
			}
		}

		private void LoadAppComponents()
		{
			boardConfig = GameObject.Find( "GameEngine" ).GetComponent<Main>().boardConfig;
			chess = GameObject.Find( "GameEngine" ).GetComponent<Main>().chess;
			gof = GameObject.Find( "GameEngine" ).GetComponent<Main>().gof;
		}

		void PlayerPicksAPiece( string originCoord )
		{
			GameObject piece = boardConfig.GetPieceFromCoord( originCoord );
			if( piece != null )
			{
				moveStatus = MoveStatus.Piece;
				selectedPiece = piece;

				ArrayList moves = chess.GetAllowedMoves( originCoord );
				foreach( string targetCoord in moves )
				{
					GameObject allowedTile = DrawAllowedTileToMove( targetCoord );
					TileInteractor.allowedMoves.Add( allowedTile );
				}
			}
		}

		void PlayerPicksATarget( string targetCoord )
		{
			Debug.Log( this.gameObject );
			if( !TileInteractor.allowedMoves.Contains( this.gameObject ) )
			{
				moveStatus = MoveStatus.Rest;

				DestroyAllowedTiles();
				return;
			}

			//chess.MovePiece( targetCoord );
			Vector2 targetPos = boardConfig.GetPositionFromTileCoord( targetCoord );
			selectedPiece.transform.position = new Vector3( targetPos.x, targetPos.y, selectedPiece.transform.position.z );

			moveStatus = MoveStatus.Rest;
			DestroyAllowedTiles();
		}

		void DestroyAllowedTiles()
		{
			foreach( GameObject tile in TileInteractor.allowedMoves )
			{
				Destroy( tile );
			}
		}

		/**
		 * Create a new tile to be placed on top of the target coordinate.
		 * 
		 * The new tile will be a bit smaller, of a different color and closer to the camera (OZ).
		 */
		private GameObject DrawAllowedTileToMove( string targetCoord )
		{
			GameObject targetTile = boardConfig.GetTileFromCoord( targetCoord );
			Vector2 tilePosition = boardConfig.GetPositionFromTileCoord( targetCoord );
			GameObject allowedTile = gof.buildTile( "Allow_" + targetCoord, tilePosition );

			allowedTile.renderer.material = TileRenderer.GetMaterial( TileRenderer.LightYellow );
			allowedTile.transform.position = new Vector3( tilePosition.x, tilePosition.y, targetTile.transform.position.z - 1 );
			allowedTile.transform.localScale -= new Vector3( 0.08f, 0.08f, 0f );

			return allowedTile;
		}
	}
}

