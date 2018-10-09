using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteSwitcher : MonoBehaviour {
	public Sprite[] sprites;

	SpriteRenderer _spriteRenderer;
	void Start () {
		_spriteRenderer = GetComponent<SpriteRenderer>();
	}

	public void SwitchToSprite(int index)
	{
		if(index < 0 || index >= sprites.Length)
		{
			Debug.LogError("Attempted to display a sprite outside the valid range: " + index);
			return;
		}

		_spriteRenderer.sprite = sprites[index];
	}
}