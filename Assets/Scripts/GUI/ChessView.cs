using System;
using UnityEngine;
using System.Collections;

namespace BitterBloom.ChessGame.GUI
{
	public class ChessView
	{
		private GameObjectFactory gof;
		private BoardConfig boardConfig;

		public ChessView( GameObjectFactory gof, BoardConfig boardConfig )
		{
			this.gof = gof;
			this.boardConfig = boardConfig;
		}

		public void DrawBoardTiles( ArrayList tiles )
		{
			foreach( string tileCoord in tiles )
			{
				Vector2 tilePosition = boardConfig.GetPositionFromTileCoord( tileCoord );

				GameObject tile = gof.buildTile( tileCoord, tilePosition );
				positionGameObject( tile, tilePosition );
			}
		}

		public void DrawBoardPieces( ArrayList pieces )
		{
			foreach( string[] pieceInfo in pieces )
			{
				string color = pieceInfo[0];
				string pieceID = pieceInfo[1];
				string coord = pieceInfo[2];

				GameObject piece = gof.buildChessPiece( color, pieceID );
				positionGameObject( piece, boardConfig.GetPositionFromTileCoord( coord ) );
			}
		}

		private void positionGameObject( GameObject go, Vector2 position )
		{
			go.transform.position = new Vector3(
				position.x,
				position.y,
				1.0f
			);
		}
	}
}

