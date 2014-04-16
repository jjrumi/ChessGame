using System;
using System.Collections;
using UnityEngine;
using BitterBloom.ChessGame.Engine;
using BitterBloom.ChessGame.GUI;

namespace BitterBloom.ChessGame.Events.Actions
{
	public class MoveFlow
	{
		private BoardConfig boardConfig;
		private IChessEngine chess;
		private MovePiece movePiece;
		private AllowedMove allowedMove;

		private enum MoveStatus {
			Rest,
			MovePiece
		}

		private static MoveStatus moveStatus = MoveStatus.Rest;
		private static GameObject selectedPiece;
		private static string originCoord;

		public MoveFlow( BoardConfig boardConfig, IChessEngine chess, GameObjectFactory gof )
		{
			this.boardConfig = boardConfig;
			this.chess = chess;

			allowedMove = new AllowedMove( boardConfig, gof );
			movePiece = new MovePiece( boardConfig );
		}

		public void Execute( string coord )
		{
			switch( moveStatus )
			{
				case MoveStatus.Rest:
					PlayerPicksAPiece( coord );
					break;

				case MoveStatus.MovePiece:
					PlayerPicksATarget( coord );
					break;
			}
		}

		private void PlayerPicksAPiece( string originCoord )
		{
			GameObject piece = boardConfig.GetPieceFromCoord( originCoord );
			if( piece != null )
			{
				ArrayList moves = chess.GetAllowedMoves( originCoord );
				if( moves.Count > 0 )
				{
					allowedMove.DrawTileList( moves );

					moveStatus = MoveStatus.MovePiece;
					selectedPiece = piece;
					MoveFlow.originCoord = originCoord;
				}
			}
		}

		private void PlayerPicksATarget( string targetCoord )
		{
			if( allowedMove.IsAnAllowedMove( targetCoord ) )
			{
				chess.MovePiece();
				movePiece.Move( selectedPiece, MoveFlow.originCoord, targetCoord );
			}

			moveStatus = MoveStatus.Rest;
			allowedMove.DestroyAllowedTiles();
		}
	}
}

