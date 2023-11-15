using System;
using UnityEngine;

namespace Suika
{
	/// <summary>
	/// Information that every Suika has.
	/// </summary>
	[Serializable]
	public struct SuikaInfo
	{
		/// <summary>
		/// Image used by the Suika.
		/// </summary>
		public Sprite Image;
		
		/// <summary>
		/// Name of the Suika.
		/// </summary>
		public string Name;
		
		/// <summary>
		/// Diameter of the Suika.
		/// </summary>
		public float Diameter;

		/// <summary>
		/// Color of the ball for debugging.
		/// </summary>
		public Color Color;
	}
}