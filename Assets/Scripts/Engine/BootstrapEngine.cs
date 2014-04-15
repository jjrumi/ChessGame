using System;

namespace BitterBloom.ChessGame.Engine
{
	public class BootstrapEngine
	{
		public static ChessEngine Execute()
		{
			ChessEngine chess = new ChessEngine(
				                    new Board(),
				                    new Player( Player.PlayerColor.White ),
				                    new Player( Player.PlayerColor.Black ),
				                    new ConfigChess()
			                    );

			return chess;
		}
	}
}

