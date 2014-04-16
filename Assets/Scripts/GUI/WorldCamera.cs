using System;
using UnityEngine;

namespace BitterBloom.ChessGame.GUI
{
	public class WorldCamera
	{
		public void Position( Vector3 vector3 )
		{
			Camera.main.transform.position = new Vector3( 3.5f, 3.5f, -10f );
		}
	}
}

