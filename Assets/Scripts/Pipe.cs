using UnityEngine;

public class Pipe : MonoBehaviour
{

    public float speed = 0.75f;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
