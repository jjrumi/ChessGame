using System;
using System.Collections.Generic;
using UnityEngine;

namespace BitterBloom.ChessGame.GUI
{
	public class PieceRenderer
	{
		private static Sprite[] chessPiecesSprite = Resources.LoadAll<Sprite>( "Sprites/pieces-sprite" );

		public static Sprite GetSprite( string pieceColor, string pieceType )
		{
			int spriteIndex = getSpritePositionFromPieceColorAndType( pieceColor, pieceType );

			return chessPiecesSprite[spriteIndex];
		}

		/**
		 * Map a piece to a sprite index.
		 */
		private static int getSpritePositionFromPieceColorAndType( string color, string type )
		{
			Dictionary<string, int> mapPieceInfoToSprite = new Dictionary<string, int>();
			mapPieceInfoToSprite.Add( "White_Pawn", 0 );
			mapPieceInfoToSprite.Add( "White_Bishop", 1 );
			mapPieceInfoToSprite.Add( "White_Knight", 2 );
			mapPieceInfoToSprite.Add( "White_Rook", 3 );
			mapPieceInfoToSprite.Add( "White_Queen", 4 );
			mapPieceInfoToSprite.Add( "White_King", 5 );

			mapPieceInfoToSprite.Add( "Black_Pawn", 6 );
			mapPieceInfoToSprite.Add( "Black_Bishop", 7 );
			mapPieceInfoToSprite.Add( "Black_Knight", 8 );
			mapPieceInfoToSprite.Add( "Black_Rook", 9 );
			mapPieceInfoToSprite.Add( "Black_Queen", 10 );
			mapPieceInfoToSprite.Add( "Black_King", 11 );

			return mapPieceInfoToSprite[color + '_' + type];
		}
	}
}

