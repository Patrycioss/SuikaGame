using UnityEngine;

public class MoveWithMouse : MonoBehaviour
{
	private void Update()
	{
		transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}
}