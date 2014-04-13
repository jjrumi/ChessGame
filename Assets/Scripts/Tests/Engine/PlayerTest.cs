using NUnit.Framework;
using System;

namespace BitterBloom.ChessGame.Engine.Tests
{
	[TestFixture()]
	public class PlayerTest
	{
		private Player player;

		[SetUp]
		public void Init()
		{
			player = new Player( Player.Color.White );
			player.Initialize();
		}

		[Test()]
		public void Initialized_Player_Has_A_Set_Pieces()
		{
			Assert.AreEqual( 16, player.Pieces.Count, "Player has 16 pieces at the beginning" );
		}

		[Test()]
		public void Initialized_Player_Has_A_King_To_Play()
		{
			Assert.IsTrue( player.Pieces.ContainsKey( ChessEngine.PieceID.King ), "Player has a King to play" );
		}
	}
}

