using System;
using System.Collections;
using System.Collections.Generic;
using BitterBloom.ChessGame.Engine.Pieces;

namespace BitterBloom.ChessGame.Engine
{
	public class Player : IPlayer
	{
		private ChessEngine.PlayerColor color;
		private Dictionary<Piece, string> setPieces;

		public Player( ChessEngine.PlayerColor color )
		{
			this.color = color;
			setPieces = null;
		}

		/**
		 * List player pieces information: [PlayerColor, PieceClassname, Coordinate].
		 */
		public ArrayList ListPieces()
		{
			ArrayList list = new ArrayList();
			foreach( KeyValuePair<Piece, string> entry in setPieces )
			{
				string[] tuple = { color.ToString(), entry.Key.GetType().Name, entry.Value };

				list.Add( tuple );
			}

			return list;
		}

		public ChessEngine.PlayerColor Color
		{
			get{ return this.color; }
		}

		public Dictionary<Piece, string> Pieces
		{
			get{ return this.setPieces; }
			set{ this.setPieces = value; }
		}
	}
}

