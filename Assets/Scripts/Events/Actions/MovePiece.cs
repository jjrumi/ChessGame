using System;
using UnityEngine;

namespace BitterBloom.ChessGame.Events.Actions
{
	public class MovePiece
	{
		private BoardConfig boardConfig;

		public MovePiece( BoardConfig boardConfig )
		{
			this.boardConfig = boardConfig;
		}

		public void Move( GameObject selectedPiece, string originCoord, string targetCoord )
		{
			boardConfig.UpdateCoordToPieceInMap( originCoord, targetCoord );
			Vector2 targetPos = boardConfig.GetPositionFromTileCoord( targetCoord );
			selectedPiece.transform.position = new Vector3( targetPos.x, targetPos.y, selectedPiece.transform.position.z );
		}
	}
}

