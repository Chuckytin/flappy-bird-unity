using UnityEngine;

public class FloorMove : MonoBehaviour
{

    public float speed = 1.25f;
    public float width = 6f; //límite máximo

    public SpriteRenderer spriteRenderer;

    private Vector2 startSize;

    void Start()
    {
        startSize = new Vector2(spriteRenderer.size.x, spriteRenderer.size.y);
    }

    void Update()
    {
        //aumenta el tamaño horizontal del Sprite con el tiempo
        spriteRenderer.size = new Vector2(spriteRenderer.size.x + speed * Time.deltaTime, spriteRenderer.size.y);

        //si el tamaño horizontal supera el límite, restablece el tamaño inicial
        if (spriteRenderer.size.x > width)
        {
            spriteRenderer.size = startSize;
        }
    }
}
