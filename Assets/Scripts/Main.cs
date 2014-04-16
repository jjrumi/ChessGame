﻿using System.Collections;
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
	 * Instantiates needed classes for the application.
	 * 
	 * Draws the scene & places the camera.
	 */
	public class Main : MonoBehaviour
	{
		private ChessView view;
		public IChessEngine chess;
		private WorldCamera worldCamera;
		public static string[] Move;

		private void Awake()
		{
			chess = BootstrapEngine.Execute();
			worldCamera = new WorldCamera();
			view = new ChessView( new GameObjectFactory(), new BoardConfig() );

			// TODO: Take move out of here! Place it in a class where it makes sense.
			Move = new string[]{ "", "" };
		}

		private void Start()
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
