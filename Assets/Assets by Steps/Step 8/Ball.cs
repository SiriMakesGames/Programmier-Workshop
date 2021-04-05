using UnityEngine;

public class Ball : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private void Awake() 
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}