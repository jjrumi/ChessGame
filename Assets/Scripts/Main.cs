using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BitterBloom.ChessGame.Engine;

namespace BitterBloom.ChessGame
{
	public class Main : MonoBehaviour
	{
		private GameObjectFactory gof;
		public ChessEngine chess;
		public static string[] Move;

		void Awake()
		{
			gof = new GameObjectFactory();
			chess = BootstrapEngine.Execute();

			Move = new string[]{ "", "" };
		}

		/**
		 * Use this for initialization
		 */
		void Start()
		{
			chess.Initialize();
			DrawScene();
			PlaceCamera();
		}

		private void DrawScene()
		{
			DrawBoardTiles();
			DrawBoardPieces();
		}

		/**
		 * Draw board tiles on the scene.
		 */
		private void DrawBoardTiles()
		{
			ArrayList tiles = chess.GetBoardTiles();

			foreach( string tileID in tiles )
			{
				Vector2 tilePosition = BoardConfig.GetPositionFromTileCoord( tileID );

				GameObject tile = gof.buildTile( tileID, tilePosition );
				positionGivenGameObject( tile, tilePosition );
			}
		}

		/**
		 * Place the given object to the given position.
		 */
		private void positionGivenGameObject( GameObject go, Vector2 position )
		{
			go.transform.position = new Vector3(
				position.x,
				position.y,
				1.0f
			);
		}

		private void DrawBoardPieces()
		{
			foreach( string[] pieceInfo in chess.GetChessPieces() )
			{
				string color = pieceInfo[0];
				string pieceID = pieceInfo[1];
				string coord = pieceInfo[2];

				GameObject piece = gof.buildChessPiece( color, pieceID );
				positionGivenGameObject( piece, BoardConfig.GetPositionFromTileCoord( coord ) );
			}
		}

		/**
		 * Point the camera to the center of the board.
		 */
		private void PlaceCamera()
		{
			Camera.main.transform.position = new Vector3( 3.5f, 3.5f, -10f );
		}
	}
}
