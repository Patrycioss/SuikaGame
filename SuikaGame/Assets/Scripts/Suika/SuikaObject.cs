using UnityEngine;

namespace Suika
{
	/// <summary>
	/// Used to make different Suikas in the editor easily.
	/// </summary>
	[CreateAssetMenu(fileName = "Suika", menuName = "Suika", order = 0)]
	public class SuikaObject : ScriptableObject
	{
		/// <summary>
		/// Info of the Suika.
		/// </summary>
		public SuikaInfo SuikaInfo => suikaInfo;
		
		[SerializeField] private SuikaInfo suikaInfo;
	}
}