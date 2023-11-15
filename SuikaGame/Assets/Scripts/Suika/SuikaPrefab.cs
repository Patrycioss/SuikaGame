using UnityEngine;

namespace Suika
{
	public class SuikaPrefab : MonoBehaviour
	{
		public SuikaInfo SuikaInfo { get; private set; }
		
		[SerializeField] private SpriteRenderer spriteRenderer;
		[SerializeField] private CircleCollider2D circleCollider2D;

		public void Instantiate(SuikaInfo suikaInfo)
		{
			SuikaInfo = suikaInfo;
			name = suikaInfo.Name;

			Vector3 scale = new(suikaInfo.Diameter, suikaInfo.Diameter);
			circleCollider2D.radius = 0.1f;
			transform.localScale = scale;
			spriteRenderer.sprite = suikaInfo.Image;
			spriteRenderer.color = suikaInfo.Color;
		}

		private void OnCollisionEnter2D(Collision2D other)
		{
			if (other.gameObject.TryGetComponent(out SuikaPrefab otherSuika))
			{
				if (otherSuika.SuikaInfo.Name == SuikaInfo.Name)
				{
					Destroy(other.gameObject);
					Destroy(gameObject);
				}
			}
		}
	}
}