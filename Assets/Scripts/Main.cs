using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BitterBloom.ChessGame.Engine;
using BitterBloom.ChessGame.GUI;

namespace BitterBloom.ChessGame
{
	/**
	 * Entry point of the application:
	 * 	Awake() -> Start() and afterwards Update() on every frame.
	 * 
	 * Bootstrap is done here.
	 * 
	 * View of the chess game.
	 */
	public class Main : MonoBehaviour
	{
		private ChessView view;
		public IChessEngine chess;
		private WorldCamera worldCamera;
		public static string[] Move;

		void Awake()
		{
			chess = BootstrapEngine.Execute();
			worldCamera = new WorldCamera();
			view = new ChessView();

			// TODO: Take move out of here! Place it in a class where it makes sense.
			Move = new string[]{ "", "" };
		}

		/**
		 * Use this for initialization
		 */
		public void Start()
		{
			chess.Initialize();
			DrawScene();
			PlaceCamera();
		}

		private void DrawScene()
		{
			view.DrawBoardTiles( chess.GetBoardTiles() );
			view.DrawBoardPieces( chess.GetChessPieces() );
		}

		/**
		 * Point the camera to the center of the board.
		 */
		private void PlaceCamera()
		{
			worldCamera.Position( new Vector3( 3.5f, 3.5f, -10f ) );
		}
	}
}
