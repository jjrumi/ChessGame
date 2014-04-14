using System;

namespace BitterBloom.ChessGame.Engine
{
	public class BootstrapEngine
	{
		public static ChessEngine Execute()
		{
			ChessEngine chess = new ChessEngine(
				new Board(),
				new Player( ChessEngine.PlayerColor.White ),
				new Player( ChessEngine.PlayerColor.Black )
			);

			return chess;
		}
	}
}

