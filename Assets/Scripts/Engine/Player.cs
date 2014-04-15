using System;
using System.Collections;
using System.Collections.Generic;
using BitterBloom.ChessGame.Engine.Pieces;

namespace BitterBloom.ChessGame.Engine
{
	public class Player : IPlayer
	{
		public enum PlayerColor
		{
			White,
			Black
		}

		private PlayerColor color;
		private Dictionary<Piece, string> setPieces;

		public Player( PlayerColor color )
		{
			this.color = color;
		}

		/**
		 * List player pieces information: [PlayerColor, PieceClassname, Coordinate].
		 */
		public ArrayList ListPieces()
		{
			ArrayList list = new ArrayList();
			System.Console.WriteLine( setPieces.Count );
			foreach( KeyValuePair<Piece, string> entry in setPieces )
			{
				string[] tuple = { color.ToString(), entry.Key.GetType().Name, entry.Value };
				list.Add( tuple );
			}

			return list; 
		}

		public PlayerColor Color { 
			get{ return this.color; }
		}

		public Dictionary<Piece, string> Pieces {
			get{ return this.setPieces; }
			set{ this.setPieces = value; }
		}
	}
}

