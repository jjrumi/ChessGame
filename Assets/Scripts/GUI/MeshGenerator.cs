using System;
using UnityEngine;

namespace BitterBloom.ChessGame
{
	public class MeshGenerator
	{
		public static Mesh CreatePlaneMesh( string name, float width, float height )
		{
			Mesh m = new Mesh();
			m.name = "PlaneMesh_" + name;
			m.vertices = new Vector3[] {
				new Vector3( -width / 2, -height / 2, 0.01f ),
				new Vector3( width / 2, -height / 2, 0.01f ),
				new Vector3( width / 2, height / 2, 0.01f ),
				new Vector3( -width / 2, height / 2, 0.01f )
			};
			m.uv = new Vector2[] {
				new Vector2( 0, 0 ),
				new Vector2( 0, 1 ),
				new Vector2( 1, 1 ),
				new Vector2( 1, 0 )
			};
			m.triangles = new int[] { 0, 2, 1, 0, 3, 2 }; // Render occurs in clockwise (CW) order.
			m.RecalculateNormals();

			return m;
		}
	}
}
