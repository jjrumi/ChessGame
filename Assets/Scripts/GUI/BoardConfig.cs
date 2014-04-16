using System;
using System.Collections.Generic;
using UnityEngine;

namespace BitterBloom.ChessGame
{
	public class BoardConfig
	{
		public Dictionary<string, Vector2> mapTileToPosition;
		public Dictionary<string, GameObject> mapCoordToPieceObject;
		public Dictionary<string, GameObject> mapCoordToTileObject;

		public BoardConfig()
		{
			mapTileToPosition = new Dictionary<string, Vector2>();
			FillUpMapTileToPosition();

			mapCoordToPieceObject = new Dictionary<string, GameObject>();
			mapCoordToTileObject = new Dictionary<string, GameObject>();
		}

		public void AddCoordToPieceInMap( string coord, GameObject piece )
		{
			mapCoordToPieceObject.Add( coord, piece );
		}

		public void AddCoordToTileInMap( string coord, GameObject tile )
		{
			mapCoordToTileObject.Add( coord, tile );
		}

		public GameObject GetPieceFromCoord( string coord )
		{
			if( mapCoordToPieceObject.ContainsKey( coord ) )
			{
				return mapCoordToPieceObject[coord];
			}

			return null;
		}

		public GameObject GetTileFromCoord( string coord )
		{
			return mapCoordToTileObject[coord];
		}

		public Vector2 GetPositionFromTileCoord( string coord )
		{
			return mapTileToPosition[coord];
		}

		private void FillUpMapTileToPosition()
		{
			mapTileToPosition.Add( "A1", new Vector2( 0, 0 ) );
			mapTileToPosition.Add( "A2", new Vector2( 0, 1 ) );
			mapTileToPosition.Add( "A3", new Vector2( 0, 2 ) );
			mapTileToPosition.Add( "A4", new Vector2( 0, 3 ) );
			mapTileToPosition.Add( "A5", new Vector2( 0, 4 ) );
			mapTileToPosition.Add( "A6", new Vector2( 0, 5 ) );
			mapTileToPosition.Add( "A7", new Vector2( 0, 6 ) );
			mapTileToPosition.Add( "A8", new Vector2( 0, 7 ) );
			mapTileToPosition.Add( "B1", new Vector2( 1, 0 ) );
			mapTileToPosition.Add( "B2", new Vector2( 1, 1 ) );
			mapTileToPosition.Add( "B3", new Vector2( 1, 2 ) );
			mapTileToPosition.Add( "B4", new Vector2( 1, 3 ) );
			mapTileToPosition.Add( "B5", new Vector2( 1, 4 ) );
			mapTileToPosition.Add( "B6", new Vector2( 1, 5 ) );
			mapTileToPosition.Add( "B7", new Vector2( 1, 6 ) );
			mapTileToPosition.Add( "B8", new Vector2( 1, 7 ) );
			mapTileToPosition.Add( "C1", new Vector2( 2, 0 ) );
			mapTileToPosition.Add( "C2", new Vector2( 2, 1 ) );
			mapTileToPosition.Add( "C3", new Vector2( 2, 2 ) );
			mapTileToPosition.Add( "C4", new Vector2( 2, 3 ) );
			mapTileToPosition.Add( "C5", new Vector2( 2, 4 ) );
			mapTileToPosition.Add( "C6", new Vector2( 2, 5 ) );
			mapTileToPosition.Add( "C7", new Vector2( 2, 6 ) );
			mapTileToPosition.Add( "C8", new Vector2( 2, 7 ) );
			mapTileToPosition.Add( "D1", new Vector2( 3, 0 ) );
			mapTileToPosition.Add( "D2", new Vector2( 3, 1 ) );
			mapTileToPosition.Add( "D3", new Vector2( 3, 2 ) );
			mapTileToPosition.Add( "D4", new Vector2( 3, 3 ) );
			mapTileToPosition.Add( "D5", new Vector2( 3, 4 ) );
			mapTileToPosition.Add( "D6", new Vector2( 3, 5 ) );
			mapTileToPosition.Add( "D7", new Vector2( 3, 6 ) );
			mapTileToPosition.Add( "D8", new Vector2( 3, 7 ) );
			mapTileToPosition.Add( "E1", new Vector2( 4, 0 ) );
			mapTileToPosition.Add( "E2", new Vector2( 4, 1 ) );
			mapTileToPosition.Add( "E3", new Vector2( 4, 2 ) );
			mapTileToPosition.Add( "E4", new Vector2( 4, 3 ) );
			mapTileToPosition.Add( "E5", new Vector2( 4, 4 ) );
			mapTileToPosition.Add( "E6", new Vector2( 4, 5 ) );
			mapTileToPosition.Add( "E7", new Vector2( 4, 6 ) );
			mapTileToPosition.Add( "E8", new Vector2( 4, 7 ) );
			mapTileToPosition.Add( "F1", new Vector2( 5, 0 ) );
			mapTileToPosition.Add( "F2", new Vector2( 5, 1 ) );
			mapTileToPosition.Add( "F3", new Vector2( 5, 2 ) );
			mapTileToPosition.Add( "F4", new Vector2( 5, 3 ) );
			mapTileToPosition.Add( "F5", new Vector2( 5, 4 ) );
			mapTileToPosition.Add( "F6", new Vector2( 5, 5 ) );
			mapTileToPosition.Add( "F7", new Vector2( 5, 6 ) );
			mapTileToPosition.Add( "F8", new Vector2( 5, 7 ) );
			mapTileToPosition.Add( "G1", new Vector2( 6, 0 ) );
			mapTileToPosition.Add( "G2", new Vector2( 6, 1 ) );
			mapTileToPosition.Add( "G3", new Vector2( 6, 2 ) );
			mapTileToPosition.Add( "G4", new Vector2( 6, 3 ) );
			mapTileToPosition.Add( "G5", new Vector2( 6, 4 ) );
			mapTileToPosition.Add( "G6", new Vector2( 6, 5 ) );
			mapTileToPosition.Add( "G7", new Vector2( 6, 6 ) );
			mapTileToPosition.Add( "G8", new Vector2( 6, 7 ) );
			mapTileToPosition.Add( "H1", new Vector2( 7, 0 ) );
			mapTileToPosition.Add( "H2", new Vector2( 7, 1 ) );
			mapTileToPosition.Add( "H3", new Vector2( 7, 2 ) );
			mapTileToPosition.Add( "H4", new Vector2( 7, 3 ) );
			mapTileToPosition.Add( "H5", new Vector2( 7, 4 ) );
			mapTileToPosition.Add( "H6", new Vector2( 7, 5 ) );
			mapTileToPosition.Add( "H7", new Vector2( 7, 6 ) );
			mapTileToPosition.Add( "H8", new Vector2( 7, 7 ) );
		}
	}
}

