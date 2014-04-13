using UnityEngine;
using System.Collections;
using BitterBloom.ChessGame.Engine;
using System.Collections.Generic;

namespace BitterBloom.ChessGame
{
	/**
	 * TODO:
	 * - Think about the design of the ChessGame.Engine part.
	 * 		- This must be developed with TDD.
	 * 		- Look for some design patterns.
	 * 		- Read external sources like http://www.daedtech.com/tdd-and-modeling-a-chess-game & http://www.hawkit.co.nz/pitofdev/tdd-chess-introduction/
	 * 		- Implement simple movement validation.
	 * - Build the pieces of the board
	 * 		- Import chess pieces.
	 * 		- Load them into the game.
	 * - Implement a very simple torn to have two players.
	 * - 
	 */
	public class Main : MonoBehaviour
	{
		private GameObjectFactory gof;

		private ChessEngine chess;

		public Main()
		{
			gof = new GameObjectFactory();
			chess = new ChessEngine();
		}

		/**
		 * Use this for initialization
		 */
		void Start() 
		{
			chess.Initialize();
			DrawBoardTiles();

			DrawBoardPieces();
					
			// Point the camera to the center of the board.
			Camera.main.transform.position = new Vector3( 3.5f, 3.5f, -10f );
		}

		/**
		 * Draw board tiles on the scene.
		 */
		private void DrawBoardTiles()
		{
			List<Tile> tiles = chess.getBoardTiles();

			for( int i = 0; i<tiles.Count; i++ )
			{
				GameObject tile = gof.buildTile( tiles[i].name, tiles[i].hPosition, tiles[i].vPosition );
				positionGivenGameObject( tile, new Vector2( tiles[i].hPosition, tiles[i].vPosition ) );
			}
		}

		/**
		 * Place the given tile object in the given X & Y positions.
		 */
		private void positionGivenGameObject( GameObject tile, Vector2 position )
		{
			tile.transform.position = new Vector3(
				position.x,
				position.y,
				1.0f
			);
		}

		private void DrawBoardPieces()
		{
			/**
			 * Algebraic notation for pieces:
			 * K: King
			 * Q: Queen
			 * R: Rook
			 * B: Bishop
			 * N: Knight
			 * P: Pawn
			 */

			//gof.buildChessPiece("W_P1");

			Sprite[] chessPieces = Resources.LoadAll<Sprite>( "Sprites/pieces-sprite" );

			// White side:
			GameObject whitePawn1 = new GameObject( "W_P1" );
			whitePawn1.AddComponent<SpriteRenderer>();
			whitePawn1.GetComponent<SpriteRenderer>().sprite = chessPieces[0];
			whitePawn1.transform.position = new Vector3( 0.0f, 1.0f, 0.0f );

			GameObject whitePawn2 = new GameObject( "W_P2" );
			whitePawn2.AddComponent<SpriteRenderer>();
			whitePawn2.GetComponent<SpriteRenderer>().sprite = chessPieces[0];
			whitePawn2.transform.position = new Vector3( 1.0f, 1.0f, 0.0f );

			GameObject whitePawn3 = new GameObject( "W_P3" );
			whitePawn3.AddComponent<SpriteRenderer>();
			whitePawn3.GetComponent<SpriteRenderer>().sprite = chessPieces[0];
			whitePawn3.transform.position = new Vector3( 2.0f, 1.0f, 0.0f );

			GameObject whitePawn4 = new GameObject( "W_P4" );
			whitePawn4.AddComponent<SpriteRenderer>();
			whitePawn4.GetComponent<SpriteRenderer>().sprite = chessPieces[0];
			whitePawn4.transform.position = new Vector3( 3.0f, 1.0f, 0.0f );

			GameObject whitePawn5 = new GameObject( "W_P5" );
			whitePawn5.AddComponent<SpriteRenderer>();
			whitePawn5.GetComponent<SpriteRenderer>().sprite = chessPieces[0];
			whitePawn5.transform.position = new Vector3( 4.0f, 1.0f, 0.0f );

			GameObject whitePawn6 = new GameObject( "W_P6" );
			whitePawn6.AddComponent<SpriteRenderer>();
			whitePawn6.GetComponent<SpriteRenderer>().sprite = chessPieces[0];
			whitePawn6.transform.position = new Vector3( 5.0f, 1.0f, 0.0f );

			GameObject whitePawn7 = new GameObject( "W_P7" );
			whitePawn7.AddComponent<SpriteRenderer>();
			whitePawn7.GetComponent<SpriteRenderer>().sprite = chessPieces[0];
			whitePawn7.transform.position = new Vector3( 6.0f, 1.0f, 0.0f );

			GameObject whitePawn8 = new GameObject( "W_P8" );
			whitePawn8.AddComponent<SpriteRenderer>();
			whitePawn8.GetComponent<SpriteRenderer>().sprite = chessPieces[0];
			whitePawn8.transform.position = new Vector3( 7.0f, 1.0f, 0.0f );

			// Black side:
			//GameObject blackKing = new GameObject( "B_King" );
			//			GameObject blackQueen = new GameObject( "B_Queen" );
		}

		/**
		 * Update is called once per frame
		 */
		void Update()
		{
		
		}
	}
}
